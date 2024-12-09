namespace InveonBootcamp.DIP.BadExample;

public class ProductService
{ 
    ProductRepository productRepository = new ProductRepository();
    public List<Product> GetProducts()
    {
        var productsList = productRepository.GetProducts();


        foreach (var product in productsList)
        {
            product.Price = product.Price * 1.2m;
        }
        
        return productsList;
    }
}