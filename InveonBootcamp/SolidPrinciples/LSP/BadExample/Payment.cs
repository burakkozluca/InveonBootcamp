namespace InveonBootcamp.LSP.BadExample;

public class Payment
{
    public virtual void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processed payment of ${amount}");
    }
}

public class CreditCardPayment : Payment
{
    public override void ProcessPayment(decimal amount)
    {
        if (amount > 1000)
        {
            throw new InvalidOperationException("Credit card payments cannot exceed $1000.");
        }

        Console.WriteLine($"Processed credit card payment of ${amount}");
    }
}

public class PayPalPayment : Payment
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processed PayPal payment of ${amount}");
    }
}

class Program
{
    static void Main()
    {
        Payment payment = new CreditCardPayment();
        payment.ProcessPayment(1200); // Hata: Credit card limitini aşar.
    }
}
