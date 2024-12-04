namespace InveonBootcamp.SRP.GoodExample.Services.Orders;

public class PaymentProcessor
{
    public void ProcessPayment(string orderDetails) => Console.WriteLine("Processing payment for order: " + orderDetails);
}