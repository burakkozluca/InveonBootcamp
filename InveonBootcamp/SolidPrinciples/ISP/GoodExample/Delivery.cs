namespace InveonBootcamp.ISP.GoodExample;


public class Customer : ICustomerActions
{
    public void AddToCart()
    {
        Console.WriteLine("Ürün sepete eklendi");
    }
}

public class Seller : ISellerActions
{
    public void ManageInventory()
    {
        Console.WriteLine("Depo güncellendi.");
    }
}

public class Delivery : IDeliveryActions
{
    public void ShipOrder()
    {
        Console.WriteLine("Teslimat hazırlanıyor.");
    }
}