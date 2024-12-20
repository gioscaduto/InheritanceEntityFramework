using FluentValidation;

namespace InheritanceEntityFramework.Entities.Validations;

class CarValidation : AbstractValidator<Car>
{
    public CarValidation()
    {
        Include(new VehicleValidation());

        RuleFor(c => c.NumberOfDoors)
           .GreaterThanOrEqualTo(1)
           .LessThanOrEqualTo(8);

        RuleFor(c => c.MaximumSpeed)
           .GreaterThanOrEqualTo(1)
           .LessThanOrEqualTo(304);
    }
}