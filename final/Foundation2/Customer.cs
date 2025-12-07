class Customer
{
    // Attributes
    private string _cName;
    private Address _address;

    //Behaviors
    public Customer(string n, Address a)
    {
        _cName = n;
        _address = a;
    }
    public string GetAddressString()
    {
        return _address.GetAddressString();
    }
    public bool getResidency()
    {
        return _address.isUsa();
    }
    public string CreateCustomerDetails()
    {
        return $"{_cName}\n{GetAddressString()}";
    }
    public string GetCustomerName()
    {
        return _cName;
    }
}