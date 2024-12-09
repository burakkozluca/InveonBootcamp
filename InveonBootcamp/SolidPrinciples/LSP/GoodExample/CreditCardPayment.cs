namespace InveonBootcamp.LSP.GoodExample;

public class CreditCardPayment : Payment
{
    private const decimal CreditCardLimit = 1000;

    public override void ProcessPayment(decimal amount)
    {
        if (amount > CreditCardLimit)
        {
            Console.WriteLine($"Error: Payment exceeds credit card limit of ${CreditCardLimit}.");
            return;
        }

        Console.WriteLine($"Processed credit card payment of ${amount}");
    }
}