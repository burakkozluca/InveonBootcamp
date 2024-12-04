namespace InveonBootcamp.SRP.GoodExample.Services.Orders;

public class InvoiceGenerator
{
    public void GenerateInvoice(string orderDetails) => Console.WriteLine("Generating invoice for order: " + orderDetails);
}