using FluentValidation.Results;
using InheritanceEntityFramework.Entities;

namespace InheritanceEntityFramework.Services;

interface IVehicleService
{
    Task<ValidationResult> Add(Vehicle vehicle);
    Task<ValidationResult> UpdateOnlySpecificProperties(Vehicle vehicle);
}
