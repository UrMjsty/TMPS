namespace TMPS2;

public class MotorcycleFactory : VehicleFactory
{
    private readonly string _model;
    private readonly Engine _engine;

    public MotorcycleFactory(string model, Engine engine)
    {
        _model = model;
        _engine = engine;
    }

    public override Vehicle CreateVehicle()
    {
        return new Motorcycle { Model = _model, Engine = _engine };
    }
}