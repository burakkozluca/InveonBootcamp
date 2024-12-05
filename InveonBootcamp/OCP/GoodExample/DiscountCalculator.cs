namespace InveonBootcamp.OCP.GoodExample;

public class DiscountCalculator
{
    private readonly Dictionary<string, IDiscount> _discounts;

    public DiscountCalculator()
    {
        _discounts = new Dictionary<string, IDiscount>
        {
            { "Electronics", new ElectronicsDiscount() },
            { "Books", new BooksDiscount() }
        };
    }

    public decimal CalculateDiscount(string category, decimal price)
    {
        if (_discounts.ContainsKey(category))
        {
            return _discounts[category].ApplyDiscount(price);
        }

        return 0; // İndirim yok
    }

}