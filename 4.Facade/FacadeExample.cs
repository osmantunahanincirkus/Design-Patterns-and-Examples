using System;

// Facade Pattern example in a home automation system

// Subsystem 1: Lighting system
class Light
{
    public void On() => Console.WriteLine("Lights are ON");
    public void Off() => Console.WriteLine("Lights are OFF");
}

// Subsystem 2: Security system
class SecuritySystem
{
    public void Arm() => Console.WriteLine("Security system is ARMED");
    public void Disarm() => Console.WriteLine("Security system is DISARMED");
}

// Subsystem 3: HVAC system
class HVAC
{
    public void SetTemperature(int temperature) => Console.WriteLine($"HVAC set to {temperature} degrees");
}

// Facade class that simplifies the interaction with all subsystems
class HomeAutomationFacade
{
    private readonly Light _light;
    private readonly SecuritySystem _securitySystem;
    private readonly HVAC _hvac;

    public HomeAutomationFacade()
    {
        _light = new Light();
        _securitySystem = new SecuritySystem();
        _hvac = new HVAC();
    }

    // Method to activate home automation
    public void Activate()
    {
        Console.WriteLine("Activating home automation system...");
        _light.On();
        _securitySystem.Arm();
        _hvac.SetTemperature(22);
    }

    // Method to deactivate home automation
    public void Deactivate()
    {
        Console.WriteLine("Deactivating home automation system...");
        _light.Off();
        _securitySystem.Disarm();
    }
}

// Client code
class Program
{
    static void Main()
    {
        // The client interacts with the home automation system through the facade
        HomeAutomationFacade homeAutomation = new HomeAutomationFacade();

        // Activate the home automation system
        homeAutomation.Activate();

        // Deactivate the home automation system
        homeAutomation.Deactivate();
    }
}
