namespace TMPS2;

public class CarFactory : VehicleFactory
{
    private readonly string _model;
    private readonly Engine _engine;

    public CarFactory(string model, Engine engine)
    {
        _model = model;
        _engine = engine;
    }

    public override Vehicle CreateVehicle()
    {
        return new Car { Model = _model, Engine = _engine };
    }
}