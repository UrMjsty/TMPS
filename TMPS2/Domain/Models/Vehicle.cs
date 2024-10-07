namespace TMPS2;
// Product: The base class for all vehicle types.

public abstract class Vehicle
{
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public abstract void ShowDetails();
}