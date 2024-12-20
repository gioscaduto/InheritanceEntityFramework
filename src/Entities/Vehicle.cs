namespace InheritanceEntityFramework.Entities;

public abstract class Vehicle : Entity
{
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public int MaximumSpeed { get; private set; }

    protected Vehicle(string brand, string model, int maximumSpeed)
    {
        Brand = brand;
        Model = model;
        MaximumSpeed = maximumSpeed;
    }
}
