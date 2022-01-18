namespace RavenStore.Core.Entities;

public class Order : Entity
{
    private readonly IList<OrderLine> _items;

    public Order(Customer customer)
    {
        Customer = customer;
        _items = new List<OrderLine>();
    }

    public Customer Customer { get; }
    public IReadOnlyCollection<OrderLine> Items => _items.ToArray();
    public decimal Discount { get; private set; } = 0;
    public decimal Total => (_items.Sum(x => x.Total) - Discount);

    public void AddItem(OrderLine item) => _items.Add(item);
    public void ApplyDiscount(decimal discount) => Discount = discount;
}