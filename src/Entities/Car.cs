namespace InheritanceEntityFramework.Entities;

public class Car : Vehicle
{
    public int NumberOfDoors { get; private set; }
    public bool HasAirConditioning { get; private set; }

    public Car(string brand, string model, int maximumSpeed, int numberOfDoors, bool hasAirConditioning)
        : base(brand, model, maximumSpeed)
    {
        NumberOfDoors = numberOfDoors;
        HasAirConditioning = hasAirConditioning;
    }

    public void Update(int numberOfDoors, bool hasAirConditioning)
    {
        NumberOfDoors = numberOfDoors;
        HasAirConditioning = hasAirConditioning;
    }
}
