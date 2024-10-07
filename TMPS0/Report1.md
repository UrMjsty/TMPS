# README for Vehicle Manufacturing Project

## Author: Ciornii Alexandr

----

## Objectives:

* Get familiar with the Creational Design Patterns (CDPs).
* Choose a specific domain (Vehicle Manufacturing).
* Implement at least 3 CDPs for the specific domain.

## Used Design Patterns:

* Singleton
* Factory Method
* Builder

## Implementation

In this project, we created a Vehicle Manufacturing system that simulates the creation of different types of vehicles (cars, trucks, motorcycles) using various creational design patterns. The implementation demonstrates how to abstract object creation and provide flexibility in extending the system for new vehicle types.

### Snippets from your files:

```csharp
// Factory Method Pattern: Abstract factory for vehicle creation.
public abstract class VehicleFactory
{
    public abstract Vehicle CreateVehicle();
}

// Singleton Pattern: Factory Manager that controls access to different factories.
public class FactoryManager
{
    private static FactoryManager _instance;

    private FactoryManager() { }

    public static FactoryManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new FactoryManager();
        }
        return _instance;
    }

    public Vehicle CreateVehicle(string type, string model, Engine engine)
    {
        // Implementation details...
    }
}
```
## Conclusions / Screenshots / Results
This project effectively demonstrates the use of creational design patterns to create a flexible and extensible vehicle manufacturing system. By utilizing the Singleton, Factory Method, and Builder patterns, we can easily manage vehicle creation and configurations. The application allows for easy extension with new vehicle types in the future.