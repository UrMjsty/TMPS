namespace TMPS2;
// Base Decorator class that implements Vehicle and wraps around an existing Vehicle.

public abstract class VehicleDecorator : Vehicle
{
    protected Vehicle _vehicle;

    public VehicleDecorator(Vehicle vehicle)
    {
        _vehicle = vehicle;
        this.Model = _vehicle.Model;
        this.Engine = _vehicle.Engine;
    }

    public override void ShowDetails()
    {
        _vehicle.ShowDetails();
    }
}