public class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;
    public Product(string productName, int productId, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }
    public string ProductName => _productName;
    public int ProductId => _productId;
    public double ProductPrice => _productPrice;
    public int ProductQuantity => _productQuantity;
    public double GetTotalCost()
    {
        double totalCost = _productPrice * _productQuantity;
        return totalCost;
    }
}