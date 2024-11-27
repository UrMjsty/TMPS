namespace ObserverPatternExample;

public class Subject<T> : ISubject<T>
{
    private readonly List<IObserver<T>> _observers = new List<IObserver<T>>();

    public void Attach(IObserver<T> observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver<T> observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(T data)
    {
        foreach (var observer in _observers)
        {
            observer.Update(data);
        }
    }
}