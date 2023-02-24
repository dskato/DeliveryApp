using FluentValidation;

namespace API.DTOs.Users
{
    public class CreateUserRequest
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Role { get; set; }

    }

    public class UserValidator : AbstractValidator<CreateUserRequest>
    {
        public UserValidator()
        {
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email address is required")
                     .EmailAddress().WithMessage("A valid email is required");

            RuleFor(p => p.Password).NotEmpty().WithMessage("Your password cannot be empty")
                    .MinimumLength(8).WithMessage("Your password length must be at least 8.")
                    .MaximumLength(16).WithMessage("Your password length must not exceed 16.");

            RuleFor(f => f.FirstName).NotEmpty().WithMessage("Firstname cannot be empty!");
            RuleFor(f => f.LastName).NotEmpty().WithMessage("Lastname cannot be empty!");
            RuleFor(f => f.Role).NotEmpty().WithMessage("Role cannot be empty!");
        }
    }
}
