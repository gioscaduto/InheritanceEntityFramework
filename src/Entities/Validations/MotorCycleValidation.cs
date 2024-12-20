using FluentValidation;

namespace InheritanceEntityFramework.Entities.Validations;

class MotorCycleValidation : AbstractValidator<MotorCycle>
{
    public MotorCycleValidation()
    {
        Include(new VehicleValidation());

        RuleFor(c => c.MaximumSpeed)
           .GreaterThanOrEqualTo(1)
           .LessThanOrEqualTo(249);
    }
}