namespace InveonBootcamp.DIP.BadExample;

public class ProductController
{
    private ProductService _productServiceservice = new ProductService();

    public List<Product> GetProducts()
    {
        return _productServiceservice.GetProducts();
    }
}