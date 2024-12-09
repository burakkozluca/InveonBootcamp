// See https://aka.ms/new-console-template for more information

using InveonBootcamp.AsenkronProgramlama;
using InveonBootcamp.DIP.BadExample;
using InveonBootcamp.LSP.GoodExample;
using InveonBootcamp.SRP.GoodExample;
using InveonBootcamp.OCP.GoodExample;

/*Console.WriteLine("Hello, World!");

var productController = new ProductController();

var products = productController.GetProducts();

foreach (var product in products)
{
    Console.WriteLine($"Id: {product.Id} Price: {product.Price}");
}*/
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

/*Payment payment1 = new CreditCardPayment();
payment1.ProcessPayment(900);

Payment payment2 = new BitcoinPayment();
payment2.ProcessPayment(1200);*/


var asyncExamples = new AsyncExamples();
var taskExamples = new TaskExamples();
var asyncAwaitExamples = new AsyncAwaitExamples();

asyncExamples.LongRunningOperationSync();
await asyncExamples.LongRunningOperationAsync();

taskExamples.RunExample();
await taskExamples.WhenAllExample();
var result = await taskExamples.FromResultExample();
Console.WriteLine(result);

await asyncAwaitExamples.FetchDataAsync();