namespace InveonBootcamp.SolidPrinciples.DIP.GoodExample;

internal class ProductRepository : IProductRepository
{
    public List<Product> GetProducts()
    {
        return new List<Product>()
        {
            new Product {Id = 1, Price = 100},
            new Product {Id = 2, Price = 200},
            new Product {Id = 3, Price = 300}
        };
    }
}