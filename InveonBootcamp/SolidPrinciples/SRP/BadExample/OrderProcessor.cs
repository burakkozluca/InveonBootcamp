namespace InveonBootcamp.SRP.BadExample;

public class OrderProcessor
{
    public void ProcessOrder(string orderDetails)
    {
        Console.WriteLine("Validating order details:" + orderDetails);

        Console.WriteLine("Processing payment for order:" + orderDetails);

        Console.WriteLine("Generating invoice for order:" + orderDetails);

        Console.WriteLine("Shipping order:" + orderDetails);

    }
}