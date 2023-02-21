using API.DTOs.Users;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace API.Extensions.Validators
{
    public class ValidatorExtension
    {
        public static void ConfigureAutoMappersServices(IServiceCollection service)
        {
            service.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
            service.AddValidatorsFromAssemblyContaining<UserValidator>();

        }
    }
}
