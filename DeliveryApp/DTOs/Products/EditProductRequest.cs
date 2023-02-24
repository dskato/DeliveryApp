using FluentValidation;

namespace API.DTOs.Products
{
    public class EditProductRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Weight { get; set; }
        public string? Description { get; set; }
    }
    public class EditProductValidator : AbstractValidator<EditProductRequest>
    {
        public EditProductValidator()
        {
            RuleFor(f => f.Name).NotEmpty().WithMessage("Name cannot be empty!");
            RuleFor(f => f.Weight).NotEmpty().WithMessage("Weight cannot be empty!");
            RuleFor(f => f.Description).NotEmpty().WithMessage("Description cannot be empty!");
        }
    }
}
