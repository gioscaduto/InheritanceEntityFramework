using InheritanceEntityFramework.Entities;

namespace InheritanceEntityFramework.FakeData;

public static class FakeData
{
    public static Car GenerateValidCar() => new Car(brand: "Bugatti", model: "Chiron Super Sport 300+",
        maximumSpeed: 304, numberOfDoors: 2, hasAirConditioning: true);

    public static MotorCycle GenerateValidMotorCycle() => new MotorCycle(brand: "Kawasaki", model: "Ninja H2R ",
        maximumSpeed: 249, hasSidecar: false);
}
