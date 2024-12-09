namespace InveonBootcamp.DIP.BadExample;

public class ProductRepository
{
    public List<Product> GetProducts()
    {
        return [
            new Product(id: 1, price: 100),
            new Product(id: 2, price: 200),
            new Product(id: 3, price: 300)
        ];
    }
}