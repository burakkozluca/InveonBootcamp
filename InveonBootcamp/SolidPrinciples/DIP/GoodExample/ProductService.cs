namespace InveonBootcamp.SolidPrinciples.DIP.GoodExample;

public class ProductService : IProductService
{
    private IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public List<Product> GetProducts()
    {
        var productsList = _productRepository.GetProducts();


        foreach (var product in productsList)
        {
            product.Price = product.Price * 1.2m;
        }
        
        return productsList;
    }
}