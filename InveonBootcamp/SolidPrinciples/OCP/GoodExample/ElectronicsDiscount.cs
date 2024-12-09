namespace InveonBootcamp.OCP.GoodExample;

public class ElectronicsDiscount : IDiscount
{
    public decimal ApplyDiscount(decimal price)
    {
        return price * 0.10m;
    }
}