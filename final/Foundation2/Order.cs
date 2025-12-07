class Order
{
    // Attributes
    private string _cName;
    private List<Product> _products;
    private string _packingLabel;
    private string _shippingLabel;
    private double _totalPrice;

    //Behaviors
    public Order(string n)
    {
        _cName = n;
        _products = new List<Product>();
        _packingLabel = "";
        _shippingLabel = "";
        _totalPrice = 0;
    }
    public void SetPackingLabel(List<Product> productList)
    {
        string label = "";
        for (int i = 0; i < productList.Count; i++)
        {
            string pName = productList[i].GetPName();
            int id = productList[i].GetId();
            int quantity = productList[i].GetQuantity();
            if (i == 0)
            {
                label = $"{i + 1}. {pName} #{id} ({quantity})";
            }
            else
            {
                label += $"\n{i + 1}. {pName} #{id} ({quantity})";
            }
        }
        _packingLabel = label;
    }
    public void SetShippingLabel(Customer currentCustomer, Address currentAddress)
    {
        currentAddress.SetAddressString();
        _shippingLabel = $"{currentCustomer.CreateCustomerDetails()}";
    }
    public void SetProducts(List<Product> productList)
    {
        foreach (Product product in productList)
        {
            _products.Add(product);
        }
    }
    public double CalcTotalPrice(Address customerAddress)
    {
        foreach (Product product in _products)
        {
            _totalPrice += product.CalcTotalCost();
        }
        if (customerAddress.isUsa())
        {
            _totalPrice += 5.00;
        }
        else
        {
            _totalPrice += 35.00;
        }
        return _totalPrice;
    }
    public void DisplayOrder(Order currentOrder)
    {
        currentOrder.SetPackingLabel(_products);
        Console.WriteLine("Package Details:");
        Console.WriteLine(_packingLabel);
        Console.WriteLine();
        Console.WriteLine("Shipping Details:");
        Console.WriteLine(_shippingLabel);
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${Math.Round(_totalPrice, 2)}");
    }
}