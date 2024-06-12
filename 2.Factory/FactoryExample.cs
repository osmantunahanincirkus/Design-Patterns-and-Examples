// Vehicle Interface and Implementations

using System;

namespace FactoryDesignPattern
{
    // The 'Product' interface
    public interface IVehicle
    {
        void Drive();
    }

    // A 'ConcreteProduct' class
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    // Another 'ConcreteProduct' class
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is riding.");
        }
    }
}

// Factory Interface and Implementation

using System;

namespace FactoryDesignPattern
{
    // The 'Creator' abstract class
    public abstract class VehicleFactory
    {
        // The factory method
        public abstract IVehicle CreateVehicle();

        public void DriveVehicle()
        {
            // Call the factory method to create a Vehicle object
            IVehicle vehicle = CreateVehicle();
            // Now use the created object
            vehicle.Drive();
        }
    }

    // A 'ConcreteCreator' class
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }

    // Another 'ConcreteCreator' class
    public class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}

// Client Code

using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create factories
            VehicleFactory carFactory = new CarFactory();
            VehicleFactory bikeFactory = new BikeFactory();

            // Use factories to create vehicles
            carFactory.DriveVehicle();
            bikeFactory.DriveVehicle();
        }
    }
}
