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
        }
    }
}
