using API.Extensions.Injections;
using API.Extensions.Migrations;
using API.Extensions.Servers;
using API.Extensions.Validators;
using Newtonsoft.Json;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR(hubOptions =>
{
    hubOptions.KeepAliveInterval = TimeSpan.FromMinutes(30);
}).AddNewtonsoftJsonProtocol(options =>
{
    options.PayloadSerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    options.PayloadSerializerSettings.DateFormatString = "yyyy-MM-ddTHH:mmZ";
});
builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
{
    builder
    .AllowAnyMethod()
    .AllowAnyHeader();
}));
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                            .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: false)
                            .Build();


builder.Services.AddMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
ServerExtension.ConfigureSQLServices(builder);
DependencyInjectionExtension.ConfigureDependenciesInjectionsServices(builder, configuration);
ValidatorExtension.ConfigureAutoMappersServices(builder.Services);


builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("corsapp");
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors("CorsPolicy");
app.MigrateDatabase();
app.Run();
