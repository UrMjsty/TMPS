namespace TMPS2;
// Singleton Pattern: Factory Manager that controls access to different factories.

public class FactoryManager
{
    private static FactoryManager _instance;

    private FactoryManager() { }

    public static FactoryManager GetInstance()
    {
        return _instance ?? (_instance = new FactoryManager());
    }

    public Vehicle CreateVehicle(string type, string model, Engine engine)
    {
        VehicleFactory factory = null;

        switch (type.ToLower())
        {
            case "car":
                factory = new CarFactory(model, engine);
                break;
            case "truck":
                factory = new TruckFactory(model, engine);
                break;
            case "motorcycle":
                factory = new MotorcycleFactory(model, engine);
                break;
        }

        return factory?.CreateVehicle();
    }
}