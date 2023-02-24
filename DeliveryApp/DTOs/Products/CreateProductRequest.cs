using FluentValidation;

namespace API.DTOs.Products
{
    public class CreateProductRequest
    {
        public string? Name { get; set; }
        public string? Weight { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
    }

    public class CreateProductValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(f => f.Name).NotEmpty().WithMessage("Name cannot be empty!");
            RuleFor(f => f.Weight).NotEmpty().WithMessage("Weight cannot be empty!");
            RuleFor(f => f.Description).NotEmpty().WithMessage("Description cannot be empty!");
        }
    }
}
