using FluentValidation;
using MvcWebUI.Models;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty();
            RuleFor(s => s.FirstName).MinimumLength(3);
            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.Address).NotEmpty();

            RuleFor(s => s.City).NotEmpty().When(s => s.Age < 18);
        }
    }
}
