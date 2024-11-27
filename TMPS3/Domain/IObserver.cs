namespace ObserverPatternExample;

public interface IObserver<T>
{
    void Update(T data);
}