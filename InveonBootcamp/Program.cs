// See https://aka.ms/new-console-template for more information

using InveonBootcamp.SRP.GoodExample.Services.Orders;

Console.WriteLine("Hello, World!");

var validator = new OrderValidator();
var paymentProcessor = new PaymentProcessor();
var invoiceGenerator = new InvoiceGenerator();
var shippingService = new ShippingService();

var orderProcessor  = new OrderProcessor(validator, paymentProcessor, invoiceGenerator, shippingService);
orderProcessor.ProcessOrder("Boat Order");