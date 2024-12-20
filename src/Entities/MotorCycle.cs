namespace InheritanceEntityFramework.Entities;

public class MotorCycle : Vehicle
{
    public bool HasSidecar { get; private set; }

    public MotorCycle(string brand, string model, int maximumSpeed, bool hasSidecar)
        : base(brand, model, maximumSpeed)
    {
        HasSidecar = hasSidecar;
    }

    public void Update(bool hasSidecar)
    {
        HasSidecar = hasSidecar;
    }
}