namespace TMPS2;
// Main Program

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vehicle Manufacturing System:");

        // Singleton Pattern: Get the factory manager instance.
        var factoryManager = FactoryManager.GetInstance();

        // Using Factory Pattern to create different vehicles.
        Vehicle car = factoryManager.CreateVehicle("car", "Tesla Model S", new ElectricEngine());
        car.ShowDetails();

        Vehicle truck = factoryManager.CreateVehicle("truck", "Volvo Truck", new DieselEngine());
        truck.ShowDetails();

        // Using Builder Pattern to build a custom motorcycle.
        Vehicle motorcycle = new VehicleBuilder()
            .CreateVehicle("motorcycle")
            .SetModel("Harley Davidson")
            .SetEngine(new DieselEngine())
            .Build();

        motorcycle.ShowDetails();

        // Adapter Pattern: Using LegacyEngine with an adapter.
        LegacyEngine legacyEngine = new LegacyEngine();
        Vehicle adaptedCar = new Car { Model = "Vintage Car", Engine = new LegacyEngineAdapter(legacyEngine) };
        adaptedCar.ShowDetails();

        // Decorator Pattern: Adding features to a car.
        Vehicle carWithGPS = new GPSDecorator(car);
        carWithGPS.ShowDetails();

        Vehicle sportsCar = new SportsPackageDecorator(carWithGPS);
        sportsCar.ShowDetails();

        // Facade Pattern: Simplified vehicle maintenance.
        VehicleMaintenanceFacade maintenanceFacade = new VehicleMaintenanceFacade();
        maintenanceFacade.PerformMaintenance();
    }
}