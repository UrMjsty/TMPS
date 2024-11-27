using System;
using System.Collections.Generic;

namespace ObserverPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a subject (generic publisher)
            var subject = new Subject<string>();

            // Create observers
            var observer1 = new ConcreteObserver<string>("Observer 1");
            var observer2 = new ConcreteObserver<string>("Observer 2");

            // Attach observers to the subject
            subject.Attach(observer1);
            subject.Attach(observer2);

            // Notify observers with some data
            Console.WriteLine("Notifying observers with 'Update 1'...");
            subject.Notify("Update 1");

            // Detach one observer
            subject.Detach(observer1);

            // Notify observers again
            Console.WriteLine("\nNotifying observers with 'Update 2'...");
            subject.Notify("Update 2");
        }
    }
}
