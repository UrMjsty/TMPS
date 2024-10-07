using System;

// Product: The base class for all vehicle types.
public abstract class Vehicle
{
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public abstract void ShowDetails();
}

// Concrete Products: Different vehicle types.
public class Car : Vehicle
{
    public override void ShowDetails()
    {
        Console.WriteLine($"Car Model: {Model}, Engine Type: {Engine.GetType().Name}");
    }
}

public class Truck : Vehicle
{
    public override void ShowDetails()
    {
        Console.WriteLine($"Truck Model: {Model}, Engine Type: {Engine.GetType().Name}");
    }
}

public class Motorcycle : Vehicle
{
    public override void ShowDetails()
    {
        Console.WriteLine($"Motorcycle Model: {Model}, Engine Type: {Engine.GetType().Name}");
    }
}

// Product Parts: Different types of engines.
public abstract class Engine { }

public class DieselEngine : Engine { }

public class ElectricEngine : Engine { }

// Factory Method Pattern: Abstract factory for vehicle creation.
public abstract class VehicleFactory
{
    public abstract Vehicle CreateVehicle();
}

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

// Builder Pattern: Allows building a complex vehicle step-by-step.
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
    }
}
