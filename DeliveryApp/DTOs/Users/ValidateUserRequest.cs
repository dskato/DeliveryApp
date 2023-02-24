using FluentValidation;

namespace API.DTOs.Users
{
    public class ValidateUserRequest
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class ValidateUserValidator : AbstractValidator<ValidateUserRequest>
    {
        public ValidateUserValidator()
        {
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email address is required")
                     .EmailAddress().WithMessage("A valid email is required");

            RuleFor(p => p.Password).NotEmpty();

        }
    }
}
