using FluentValidation;

namespace API.DTOs.Users
{
    public class EditUserInfoRequest
    {
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
    }

    public class UserEditValidator : AbstractValidator<EditUserInfoRequest>
    {
        public UserEditValidator()
        {
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email address is required")
                     .EmailAddress().WithMessage("A valid email is required");

           

            RuleFor(f => f.FirstName).NotEmpty().WithMessage("Firstname cannot be empty!");
            RuleFor(f => f.LastName).NotEmpty().WithMessage("Lastname cannot be empty!");
            RuleFor(f => f.Address).NotEmpty().WithMessage("Lastname cannot be empty!");
        }
    }
}
