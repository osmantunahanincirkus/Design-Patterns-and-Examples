using System;

// Singleton class to manage logging
public sealed class Logger
{
    // Private static instance of the same class
    private static Logger instance = null;
    // Lock synchronization object
    private static readonly object padlock = new object();

    // Private constructor to prevent instantiation from outside
    private Logger()
    {
        // Initialize log settings if necessary
    }

    // Public static method to provide a global point of access to the instance
    public static Logger Instance
    {
        get
        {
            // Ensure thread safety
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
    }

    // Example method to log messages
    public void Log(string message)
    {
        // Here, we simply write the log message to the console
        // In a real-world application, you might write to a file, database, etc.
        Console.WriteLine($"Log: {message}");
    }
}

// Example client class to demonstrate the usage of Singleton
public class Client
{
    public static void Main(string[] args)
    {
        // Access the Singleton instance
        Logger logger1 = Logger.Instance;
        logger1.Log("First log message.");

        // Access the Singleton instance from another part of the application
        Logger logger2 = Logger.Instance;
        logger2.Log("Second log message.");

        // Check if both instances are the same
        if (logger1 == logger2)
        {
            Console.WriteLine("Both instances are the same.");
        }
        else
        {
            Console.WriteLine("Instances are different.");
        }
    }
}
