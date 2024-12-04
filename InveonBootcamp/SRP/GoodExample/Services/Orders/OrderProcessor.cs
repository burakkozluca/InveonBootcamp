namespace InveonBootcamp.SRP.GoodExample.Services.Orders;

public class OrderProcessor
{
    private readonly OrderValidator _orderValidator;
    private readonly PaymentProcessor _paymentProcessor;
    private readonly InvoiceGenerator _invoiceGenerator;
    private readonly ShippingService _shippingService;

    public OrderProcessor(OrderValidator orderValidator, PaymentProcessor paymentProcessor, InvoiceGenerator invoiceGenerator, ShippingService shippingService)
    {
        _orderValidator = orderValidator;
        _paymentProcessor = paymentProcessor;
        _invoiceGenerator = invoiceGenerator;
        _shippingService = shippingService;
    }

    public void ProcessOrder(string orderDetails)
    {
        _orderValidator.Validate(orderDetails);
        _paymentProcessor.ProcessPayment(orderDetails);
        _invoiceGenerator.GenerateInvoice(orderDetails);
        _shippingService.ShipOrder(orderDetails);
    }
}