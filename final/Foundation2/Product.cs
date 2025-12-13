class Product
{
    // Attributes
    private string _pName;
    private int _id;
    private double _price;
    private int _quantity;

    //Behaviors
    public Product(string n, int i, double p, int q)
    {
        _pName = n;
        _id = i;
        _price = p;
        _quantity = q;
    }
    public string GetPName()
    {
        return _pName;
    }
    public int GetId()
    {
        return _id;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double CalcTotalCost()
    {
        return _price * _quantity;
    }
}