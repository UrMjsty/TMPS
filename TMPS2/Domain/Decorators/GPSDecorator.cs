namespace TMPS2;
// Concrete Decorator class for adding a GPS feature to the vehicle.

public class GPSDecorator : VehicleDecorator
{
    public GPSDecorator(Vehicle vehicle) : base(vehicle) { }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Added Feature: GPS Navigation System.");
    }
}