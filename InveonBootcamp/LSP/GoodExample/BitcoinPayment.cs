namespace InveonBootcamp.LSP.GoodExample;

public class BitcoinPayment : Payment
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processed Bitcoin payment of ${amount}");
    }
}