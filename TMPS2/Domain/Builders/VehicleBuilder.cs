namespace TMPS2;
// Builder Pattern: Allows building a complex vehicle step-by-step.x

public class VehicleBuilder
{
    private Vehicle _vehicle;

    public VehicleBuilder CreateVehicle(string type)
    {
        switch (type.ToLower())
        {
            case "car":
                _vehicle = new Car();
                break;
            case "truck":
                _vehicle = new Truck();
                break;
            case "motorcycle":
                _vehicle = new Motorcycle();
                break;
        }
        return this;
    }

    public VehicleBuilder SetModel(string model)
    {
        _vehicle.Model = model;
        return this;
    }

    public VehicleBuilder SetEngine(Engine engine)
    {
        _vehicle.Engine = engine;
        return this;
    }

    public Vehicle Build()
    {
        return _vehicle;
    }
}