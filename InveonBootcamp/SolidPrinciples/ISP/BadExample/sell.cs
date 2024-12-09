namespace InveonBootcamp.ISP.BadExample;

public interface IUser
{
    void AddToCart();
    void ShipOrder();
    void ManageInventory();
}

public class Customer : IUser
{
    public void AddToCart()
    {
        Console.WriteLine("Ürün sepete eklendi");
    }

    public void ShipOrder()
    {
        throw new NotImplementedException();
    }

    public void ManageInventory()
    {
        throw new NotImplementedException();
    }
}

public class Seller : IUser
{
    public void AddToCart()
    {
        throw new NotImplementedException();
    }

    public void ShipOrder()
    {
        throw new NotImplementedException();
    }

    public void ManageInventory()
    {
        Console.WriteLine("stok güncellendi");
    }
}

public class sell : IUser
{
    public void AddToCart()
    {
        throw new NotImplementedException();
    }

    public void ShipOrder()
    {
        Console.WriteLine("kargo güncellendi");
    }

    public void ManageInventory()
    {
        throw new NotImplementedException();
    }
}
