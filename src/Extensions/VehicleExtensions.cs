using InheritanceEntityFramework.Entities;

namespace InheritanceEntityFramework.Extensions
{
    public static class VehicleExtensions
    {
        public static int? GetNumberOfDoors(this Vehicle vehicle)
        {
            if (vehicle is Car car)
                return car.NumberOfDoors;

            return null;
        }

        public static bool? GetHasAirConditioning(this Vehicle vehicle)
        {
            if (vehicle is Car car)
                return car.HasAirConditioning;

            return null;
        }

        public static bool? GetHasSidecar(this Vehicle vehicle)
        {
            if (vehicle is MotorCycle motorCycle)
                return motorCycle.HasSidecar;

            return null;
        }
    }
}
