using InheritanceEntityFramework.Data;
using InheritanceEntityFramework.Entities;
using InheritanceEntityFramework.Entities.Validations;
using InheritanceEntityFramework.Extensions;

namespace InheritanceEntityFramework.Repositories;

class VehicleRepository(AppDbContext context) : IVehicleRepository
{
    private readonly AppDbContext _context = context;
    
    public async Task Add(Vehicle vehicle)
    {
        _context.Add(vehicle);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateOnlySpecificProperties(Vehicle vehicle)
    {
        switch (vehicle)
        {
            case Car car:
                _context.Entry(vehicle).Property(nameof(Car.NumberOfDoors))
                        .CurrentValue = vehicle.GetNumberOfDoors();

                _context.Entry(vehicle).Property(nameof(Car.HasAirConditioning))
                        .CurrentValue = vehicle.GetHasAirConditioning();
                break;
            case MotorCycle motorCycle:
                _context.Entry(vehicle).Property(nameof(MotorCycle.HasSidecar))
                        .CurrentValue = vehicle.GetHasSidecar();
                break;
            default:
                throw new NotImplementedException(nameof(Vehicle));
        }

        await _context.SaveChangesAsync();
    }
}
