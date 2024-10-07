# Structural Design Patterns Implementation Report

## Author: Ciornii Alexandr

----

## Objectives:

1. Study and understand the Structural Design Patterns.
2. Implement three structural design patterns: Adapter, Decorator, and Facade.
3. Demonstrate how these patterns can enhance and extend the functionality of the existing Vehicle Management System.

## Theoretical Background

Structural Design Patterns focus on how classes and objects are composed to form larger structures. They allow for flexibility in how classes interact and provide solutions for efficiently structuring complex systems. These patterns are particularly useful for integrating new components into existing systems, adding new features dynamically, and simplifying complex subsystems.

In this report, we will showcase three design patterns:
- **Adapter Pattern**: Allows incompatible interfaces to work together.
- **Decorator Pattern**: Adds new behavior to an existing object without modifying its structure.
- **Facade Pattern**: Provides a simplified interface to a complex subsystem.

## Implementation & Explanation

### 1. Adapter Pattern

**Purpose:** The Adapter pattern allows an existing class with an incompatible interface to be used as if it implemented the expected interface. In our Vehicle Management System, we have a new type of `LegacyEngine` that does not implement the `Engine` interface, making it incompatible with the rest of the system.

**Solution:** We created an `LegacyEngineAdapter` that implements the `Engine` interface and internally uses a `LegacyEngine` object. This allows us to integrate `LegacyEngine` without changing its internal code.

**Code Snippet:**
```csharp
// New type of legacy engine that does not match our system's Engine interface.
public class LegacyEngine
{
    public void StartEngine() => Console.WriteLine("Legacy Engine started.");
}

// Adapter class that wraps the LegacyEngine and makes it compatible with Engine.
public class LegacyEngineAdapter : Engine
{
    private LegacyEngine _legacyEngine;

    public LegacyEngineAdapter(LegacyEngine legacyEngine)
    {
        _legacyEngine = legacyEngine;
    }

    public void Start() => _legacyEngine.StartEngine();
}
```
### Location: src/adapters/LegacyEngineAdapter.cs

**Main Idea:** This pattern bridges the gap between the legacy engine and the modern system by adapting the interface, allowing us to use both types of engines interchangeably.

2. **Decorator Pattern**
Purpose: The Decorator pattern allows adding new responsibilities to an object dynamically without altering its structure. This is useful when we want to add features to individual vehicles, such as a GPS navigation system or a sports package, without modifying the core Vehicle class.

**Solution:** We implemented a base VehicleDecorator class and created concrete decorators (GPSDecorator and SportsPackageDecorator). These decorators add specific features while preserving the core functionality of the vehicle.

**Code Snippet:**

```csharp
// Base Decorator class that implements Vehicle and wraps around an existing Vehicle.
public abstract class VehicleDecorator : Vehicle
{
    protected Vehicle _vehicle;

    public VehicleDecorator(Vehicle vehicle)
    {
        _vehicle = vehicle;
        this.Model = _vehicle.Model;
        this.Engine = _vehicle.Engine;
    }

    public override void ShowDetails()
    {
        _vehicle.ShowDetails();
    }
}

// Concrete Decorator class for adding a GPS feature to the vehicle.
public class GPSDecorator : VehicleDecorator
{
    public GPSDecorator(Vehicle vehicle) : base(vehicle) { }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Added Feature: GPS Navigation System.");
    }
}

// Concrete Decorator class for adding a Sports Package to the vehicle.
public class SportsPackageDecorator : VehicleDecorator
{
    public SportsPackageDecorator(Vehicle vehicle) : base(vehicle) { }

    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine("Added Feature: Sports Package.");
    }
}
```
### Location: src/decorators/GPSDecorator.cs and src/decorators/SportsPackageDecorator.cs

**Main Idea**: This pattern allows us to add features like a GPS system or a sports package to a vehicle dynamically, without altering the Vehicle class. It ensures that existing code remains untouched and only new functionality is added.

3. **Facade Pattern Purpose:**
The Facade pattern provides a simplified interface to a complex subsystem. It hides the complexities of the system and provides a unified interface to clients. In our Vehicle Management System, there are several independent maintenance tasks (e.g., engine check, oil change, and vehicle wash) that need to be performed sequentially.

**Solution**: We created a VehicleMaintenanceFacade that provides a single method to perform all maintenance tasks in the correct order, hiding the complexities of individual tasks.

**Code Snippet:**

```csharp

// Subsystem classes for various maintenance tasks.
public class EngineCheck
{
    public void Check() => Console.WriteLine("Engine check completed.");
}

public class OilChange
{
    public void Change() => Console.WriteLine("Oil changed successfully.");
}

public class VehicleWash
{
    public void Wash() => Console.WriteLine("Vehicle washed and cleaned.");
}

// Facade class that simplifies the maintenance process.
public class VehicleMaintenanceFacade
{
    private EngineCheck _engineCheck;
    private OilChange _oilChange;
    private VehicleWash _vehicleWash;

    public VehicleMaintenanceFacade()
    {
        _engineCheck = new EngineCheck();
        _oilChange = new OilChange();
        _vehicleWash = new VehicleWash();
    }

    public void PerformMaintenance()
    {
        _engineCheck.Check();
        _oilChange.Change();
        _vehicleWash.Wash();
        Console.WriteLine("All maintenance tasks completed.");
    }
}
```
### Location: src/facades/VehicleMaintenanceFacade.cs

**Main Idea:** This pattern simplifies complex maintenance processes into a single interface, allowing the client to perform maintenance without needing to understand the details of each subsystem.

### Results/Screenshots/Conclusions
The implementation of these structural design patterns in the Vehicle Management System has improved its flexibility, maintainability, and usability: <br>
**Adapter Pattern:** Enabled integration of a new LegacyEngine without modifying existing code.<br>
**Decorator Pattern:** Added new features to vehicles dynamically, such as GPS and sports packages, without altering the core Vehicle class.<br>
**Facade Pattern:** Simplified the maintenance process, providing a single method to perform multiple independent tasks.<br>
**Overall**, these design patterns contributed to creating a more extensible and robust system, demonstrating the power of structural design patterns in software architecture.