namespace TMPS2;

public class TruckFactory : VehicleFactory
{
    private readonly string _model;
    private readonly Engine _engine;

    public TruckFactory(string model, Engine engine)
    {
        _model = model;
        _engine = engine;
    }

    public override Vehicle CreateVehicle()
    {
        return new Truck { Model = _model, Engine = _engine };
    }
}