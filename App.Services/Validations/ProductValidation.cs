using App.Core.Entities.ProductManagment;
using FluentValidation;

namespace App.Services.Validations
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Product name is required.")
                .Length(2, 50).WithMessage("Product name must be between 2 and 50 characters.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Product description is required.")
                .Length(10, 200).WithMessage("Product description must be between 10 and 200 characters.");

            RuleFor(x => x.RegularPrice)
                .GreaterThan(0).WithMessage("Product price must be greater than zero.");

            RuleFor(x => x.Stock)
                .GreaterThanOrEqualTo(0).WithMessage("Stock quantity cannot be negative.");
        }
    }
}
