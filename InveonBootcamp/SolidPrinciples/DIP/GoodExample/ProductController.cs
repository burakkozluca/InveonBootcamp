namespace InveonBootcamp.SolidPrinciples.DIP.GoodExample;

public class ProductController
{
    private IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    public List<Product> GetProducts()
    {
        return _productService.GetProducts();
    }
}