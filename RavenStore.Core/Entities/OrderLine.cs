namespace RavenStore.Core.Entities;

public class OrderLine : Entity
{
    public OrderLine(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public Product Product { get; }
    public int Quantity { get; }
    public decimal Total => Quantity * Product.Price;
}