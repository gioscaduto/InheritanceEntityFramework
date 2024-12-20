using FluentValidation;

namespace InheritanceEntityFramework.Entities.Validations;

class VehicleValidation : AbstractValidator<Vehicle>
{
    public VehicleValidation()
    {
        RuleFor(c => c.Brand)
           .NotEmpty()
           .Length(1, 255);

        RuleFor(c => c.Model)
           .NotEmpty()
           .Length(1, 255);
    }
}