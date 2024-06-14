using System;
using System.Collections.Generic;

// Define a Subject class that maintains a list of observers and notifies them of state changes.
public class Subject
{
    private List<IObserver> observers = new List<IObserver>();

    // Method to attach observers to the subject.
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    // Method to detach observers from the subject.
    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    // Method to notify all observers of a state change.
    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }

    // Simulate a state change and notify observers.
    public void ChangeState()
    {
        Console.WriteLine("Subject: State has changed.");
        Notify();
    }
}

// Define an Observer interface with an update method.
public interface IObserver
{
    void Update();
}

// Define concrete Observer classes that implement the update method.
public class ConcreteObserverA : IObserver
{
    public void Update()
    {
        Console.WriteLine("ConcreteObserverA: Reacted to the state change.");
    }
}

public class ConcreteObserverB : IObserver
{
    public void Update()
    {
        Console.WriteLine("ConcreteObserverB: Reacted to the state change.");
    }
}

// Demonstrate the Observer Design Pattern.
class Program
{
    static void Main(string[] args)
    {
        // Create subject and attach observers.
        var subject = new Subject();
        var observer1 = new ConcreteObserverA();
        var observer2 = new ConcreteObserverB();
        subject.Attach(observer1);
        subject.Attach(observer2);

        // Trigger state change.
        subject.ChangeState();

        // Detach observer1 and trigger state change again.
        subject.Detach(observer1);
        subject.ChangeState();
    }
}
