using Domain.Interfaces;
using Infrastructure.Data.Repositories;

namespace API.Extensions.Injections
{
    public class DependencyInjectionExtension
    {
        public static void ConfigureDependenciesInjectionsServices(WebApplicationBuilder builder, IConfiguration configuration) {

            builder.Services.AddScoped<IApplicationService, ApplicationService>();
            builder.Services.AddScoped<IUserDomainRepository, UserRepository>();
            builder.Services.AddScoped<IProductDomainRepository, ProductRepository>();
            builder.Services.AddScoped<IOrderDomainRepository, OrderRepository>();

        }
    }
}
