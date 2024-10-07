namespace TMPS2;
// Concrete Decorator class for adding a Sports Package to the vehicle.

public class SportsPackageDecorator : VehicleDecorator
{
    public SportsPackageDecorator(Vehicle vehicle) : base(vehicle) { }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Added Feature: Sports Package.");
    }
}