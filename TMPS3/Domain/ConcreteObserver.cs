namespace ObserverPatternExample;

public class ConcreteObserver<T> : IObserver<T>
{
    private readonly string _name;

    public ConcreteObserver(string name)
    {
        _name = name;
    }

    public void Update(T data)
    {
        Console.WriteLine($"{_name} received update: {data}");
    }
}