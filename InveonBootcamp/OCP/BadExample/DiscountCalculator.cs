namespace InveonBootcamp.OCP.BadExample;

public class DiscountCalculator
{
    public decimal CalculateDiscount(string category, decimal price)
    {
        if (category == "Electronics")
        {
            return price * 0.10m; // %10 indirim
        }
        else if (category == "Books")
        {
            return price * 0.05m; // %5 indirim
        }
        else
        {
            return 0; // İndirim yok
        }
    }
}