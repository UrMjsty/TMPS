namespace TMPS2;
// Concrete Products: Different vehicle types.

public class Car : Vehicle
{
    public override void ShowDetails()
    {
        Console.WriteLine($"Car Model: {Model}, Engine Type: {Engine.GetType().Name}");
    }
}