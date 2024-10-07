namespace TMPS2;
// Concrete Products: Different vehicle types.

public class Motorcycle : Vehicle
{
    public override void ShowDetails()
    {
        Console.WriteLine($"Motorcycle Model: {Model}, Engine Type: {Engine.GetType().Name}");
    }
}