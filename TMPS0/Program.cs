using System;
using System.Collections.Generic;

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

class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();
        
        // Creating a list of shapes (demonstrating OCP).
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle(10, 5),
            new Circle(7)
        };

        // Calculating and logging the area of each shape.
        foreach (var shape in shapes)
        {
            double area = shape.CalculateArea();
            logger.Log($"The area of {shape.GetType().Name} is: {area}");
        }
    }
}