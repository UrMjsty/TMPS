# README for Shapes Area Calculation Program

## Author: Ciornii Alexandr

----

## Objectives:

* Get familiar with the SOLID principles.
* Implement examples demonstrating Single Responsibility Principle (SRP) and Open/Closed Principle (OCP).
* Create a simple program that calculates the area of different shapes.

## Used Design Patterns:

* Single Responsibility Principle (SRP)
* Open/Closed Principle (OCP)

## Implementation

This program implements two of the SOLID principles: SRP and OCP. The `Logger` class is responsible solely for logging, adhering to the Single Responsibility Principle. The `Shape` class is designed to be open for extension but closed for modification, as seen with the `Rectangle` and `Circle` classes, which inherit from `Shape` and implement the `CalculateArea` method.

### Snippets from your files:

```csharp
// SRP: Logger class handles only logging functionality.
public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

// OCP: Base Shape class is closed for modification but open for extension.
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
```
## Conclusions / Screenshots / Results

The program successfully demonstrates the implementation of the SOLID principles by creating a flexible and maintainable code structure. The Logger class adheres to SRP by only handling logging, while the Shape class and its derived classes adhere to OCP by allowing the addition of new shapes without modifying existing code. This design promotes easy extensibility for future shapes and logging functionalities.