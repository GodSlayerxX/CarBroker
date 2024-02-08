using FluentValidation;
using CarBroker.Models.User;

namespace CarBroker.Validators
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.ManufacturerId).NotNull().GreaterThan(0);

            RuleFor(x => x.Name).NotEmpty().MinimumLength(2);

            RuleFor(x => x.Id).NotEmpty().GreaterThan(0);

            RuleFor(x => x.Price).NotNull().GreaterThan(0);
        }
    }
}
