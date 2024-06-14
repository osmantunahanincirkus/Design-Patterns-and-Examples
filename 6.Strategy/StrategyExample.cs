using System;

// Define a payment strategy interface.
public interface IPaymentStrategy
{
    void Pay(double amount);
}

// Define concrete payment strategies.
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using credit card.");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using PayPal.");
    }
}

public class CashPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} in cash.");
    }
}

// Define a class that uses the payment strategy.
public class ShoppingCart
{
    private readonly IPaymentStrategy _paymentStrategy;

    public ShoppingCart(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Checkout(double amount)
    {
        _paymentStrategy.Pay(amount);
    }
}

// Demonstrate the Strategy Design Pattern.
class Program
{
    static void Main(string[] args)
    {
        // Create a shopping cart with different payment strategies.
        var cart1 = new ShoppingCart(new CreditCardPayment());
        var cart2 = new ShoppingCart(new PayPalPayment());
        var cart3 = new ShoppingCart(new CashPayment());

        // Simulate checkout process with different amounts.
        cart1.Checkout(100.50);
        cart2.Checkout(75.25);
        cart3.Checkout(50.00);
    }
}
