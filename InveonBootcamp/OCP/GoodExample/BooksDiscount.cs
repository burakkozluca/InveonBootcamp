namespace InveonBootcamp.OCP.GoodExample;

public class BooksDiscount : IDiscount
{
    public decimal ApplyDiscount(decimal price)
    {
        return price * 0.05m; // %5 indirim
    }
}