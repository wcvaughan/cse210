public class Order
{
    public Customer _customer;
    public List<Product> _products { get; set;}
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public Customer Customer => _customer;
    public List<Product> Products => _products;
    public void GetPackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"Product: {p.ProductName} - ProductID: {p.ProductId} Quantity: {p.ProductQuantity}");
        }
    }
    public void GetShippingLabel()
    {
        Console.WriteLine($"Customer: {_customer.Name}");
        Console.WriteLine($"Address: {_customer.Address.DisplayAddress()}");

    }
    public double GetTotalCost()
    {
        double totalMinusShipping = 0;
        foreach(Product p in _products)
        {
            totalMinusShipping += p.GetTotalCost();
        }


        double shippingCost = _customer.LocalorForeign() ? 5 : 35;
        return totalMinusShipping + shippingCost;
    }
}