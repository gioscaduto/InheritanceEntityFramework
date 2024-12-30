using InheritanceEntityFramework.Data;
using InheritanceEntityFramework.Entities;

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
                _context.Entry(car).Property(nameof(Car.NumberOfDoors))
                        .CurrentValue = car.NumberOfDoors;

                _context.Entry(car).Property(nameof(Car.HasAirConditioning))
                        .CurrentValue = car.HasAirConditioning;
                break;
            case MotorCycle motorCycle:
                _context.Entry(motorCycle).Property(nameof(MotorCycle.HasSidecar))
                        .CurrentValue = motorCycle.HasSidecar;
                break;
            default:
                throw new NotImplementedException(nameof(Vehicle));
        }

        await _context.SaveChangesAsync();
    }
}
