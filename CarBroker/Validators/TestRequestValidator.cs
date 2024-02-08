using FluentValidation;
using CarBroker.Models.Request;

namespace CarBroker.Validators
{
    public class GetCarsByManufacturerRequestValidator : AbstractValidator<GetCarsByManufacturerRequest>
    {
        public GetCarsByManufacturerRequestValidator()
        {
            RuleFor(test => test.ManufacturerId).NotNull().GreaterThan(0).LessThan(10);

            RuleFor(test => test.MinPrice).InclusiveBetween(0, decimal.MaxValue).When(test => test.MinPrice.HasValue);

            RuleFor(test => test.MaxPrice).InclusiveBetween(0, decimal.MaxValue).When(test => test.MaxPrice.HasValue);
        }
    }
}
