using InheritanceEntityFramework.Entities;

namespace InheritanceEntityFramework.Repositories;

interface IVehicleRepository
{
    Task Add(Vehicle vehicle);
    Task UpdateOnlySpecificProperties(Vehicle vehicle);
}
