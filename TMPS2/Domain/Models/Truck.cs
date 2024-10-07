namespace TMPS2;
// Concrete Products: Different vehicle types.

public class Truck : Vehicle
{
    public override void ShowDetails()
    {
        Console.WriteLine($"Truck Model: {Model}, Engine Type: {Engine.GetType().Name}");
    }
}