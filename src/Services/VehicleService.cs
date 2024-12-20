using FluentValidation.Results;
using InheritanceEntityFramework.Entities;
using InheritanceEntityFramework.Entities.Validations;
using InheritanceEntityFramework.Repositories;

namespace InheritanceEntityFramework.Services;

class VehicleService(IVehicleRepository vehicleRepository) : IVehicleService
{
    private readonly IVehicleRepository _vehicleRepository = vehicleRepository;

    public async Task<ValidationResult> Add(Vehicle vehicle)
    {
        var validation = Validate(vehicle);

        if (!validation.IsValid) return validation;
        
        await _vehicleRepository.Add(vehicle);
        
        return validation;
    }

    /// <summary>
    /// It dont't update properties in vehicle base class 
    /// It update only properties in sub class
    /// </summary>
    public async Task<ValidationResult> UpdateOnlySpecificProperties(Vehicle vehicle)
    {
        var validation = Validate(vehicle);

        if (!validation.IsValid) return validation;

        await _vehicleRepository.UpdateOnlySpecificProperties(vehicle);   

        return validation;
    }

    private ValidationResult Validate(Vehicle vehicle) =>
        vehicle switch
        {
            Car car =>
                new CarValidation().Validate(car),
            MotorCycle motorCycle =>
                new MotorCycleValidation().Validate(motorCycle),
            _ =>
                throw new NotImplementedException(nameof(Vehicle))
        };
}
