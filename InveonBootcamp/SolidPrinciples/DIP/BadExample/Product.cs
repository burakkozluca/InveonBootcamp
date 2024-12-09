namespace InveonBootcamp.DIP.BadExample;

public class Product
{
    public Product()
    {
    }

    public Product(int id, decimal price)
    {
        Id = id;
        Price = price;
    }

    public int Id { get; set; }
    public decimal Price { get; set; }
}