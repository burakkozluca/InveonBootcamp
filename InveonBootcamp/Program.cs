// See https://aka.ms/new-console-template for more information

using InveonBootcamp.LSP.GoodExample;
using InveonBootcamp.SRP.GoodExample;
using InveonBootcamp.OCP.GoodExample;

Console.WriteLine("Hello, World!");

// var validator = new OrderValidator();
// var paymentProcessor = new PaymentProcessor();
// var invoiceGenerator = new InvoiceGenerator();
// var shippingService = new ShippingService();
//
// var orderProcessor  = new OrderProcessor(validator, paymentProcessor, invoiceGenerator, shippingService);
// orderProcessor.ProcessOrder("Boat Order");

/*var calculator = new DiscountCalculator();

var electronicsPrice = calculator.CalculateDiscount("Electronics", 1000);
Console.WriteLine($"Electronics Price after Discount: {electronicsPrice}");

var booksPrice = calculator.CalculateDiscount("Books", 500);
Console.WriteLine($"Books Price after Discount: {booksPrice}");

var otherPrice = calculator.CalculateDiscount("Clothing", 300);
Console.WriteLine($"Clothing Price after Discount: {otherPrice}");*/



Animal dog = new Dog();
dog.Speak();

Animal cat = new Cat();
cat.Speak();
