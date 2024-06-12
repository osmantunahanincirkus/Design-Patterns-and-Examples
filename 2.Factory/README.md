# Factory Design Pattern

## Introduction

The Factory Design Pattern is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. The Factory Pattern promotes loose coupling by eliminating the need for the client code to specify the concrete class of the object to be created.

This pattern is particularly useful in scenarios where the exact type of the object to be created is determined at runtime. It provides a centralized mechanism for object creation, making the system more modular and easier to extend.

## Benefits of Factory Design Pattern

- **Promotes Loose Coupling:** The factory pattern decouples the client code from the concrete classes it needs to instantiate, making the system more flexible and easier to maintain.
- **Centralizes Object Creation:** Object creation is handled by factory classes, centralizing the instantiation logic and reducing code duplication.
- **Improves Code Maintainability:** Changes to object creation logic need to be made in the factory class only, reducing the impact of changes on the client code.
- **Enhances Extensibility:** New types of objects can be added easily by extending the factory class without modifying the existing client code.
- **Encourages Code Reusability:** Common object creation code is encapsulated within factory classes, promoting reuse across the application.

## Explanation of Example

The provided code scenario illustrates the Factory Design Pattern by simulating a vehicle factory that can create different types of vehicles (Car and Bike). This example demonstrates how the factory pattern can be used to create objects based on runtime information.

### Vehicle Interface and Implementations

The `IVehicle` interface defines the `Drive` method, which must be implemented by all concrete vehicle classes. The `Car` and `Bike` classes implement this interface, each providing their own implementation of the `Drive` method.

### Factory Interface and Implementation

The `VehicleFactory` abstract class defines a factory method `CreateVehicle` for creating vehicle objects. The `CarFactory` and `BikeFactory` classes extend this abstract class and override the `CreateVehicle` method to return instances of `Car` and `Bike`, respectively.

### Client Code

The client code demonstrates how to use the factory pattern to create and drive vehicles without needing to know the concrete classes involved.

## Conclusion

The Factory Design Pattern is a powerful tool for managing object creation in a flexible and maintainable manner. By centralizing the instantiation logic and decoupling the client code from concrete classes, the factory pattern promotes loose coupling, improves code maintainability, and enhances the extensibility of the system.

By understanding and applying the Factory Design Pattern, developers can create more robust and scalable software solutions that adhere to best practices in software design.

## References

- Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides. "Design Patterns: Elements of Reusable Object-Oriented Software" Addison-Wesley, 1994.
- [Factory Method on Wikipedia](https://en.wikipedia.org/wiki/Factory_method_pattern)
