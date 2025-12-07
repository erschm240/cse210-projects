class Address
{
    // Attributes
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _inUsa;
    private string _addressString;

    //Behaviors
    public Address(string street, string city, string state, string country, bool i)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
        _inUsa = i;
    }
    public bool isUsa()
    {
        return _inUsa;
    }
    public void SetAddressString()
    {
        if (_inUsa)
        {
            _addressString = $"{_streetAddress}\n{_city}, {_state}\n{_country}";
        }
        else
        {
            _addressString = $"{_streetAddress}\n{_city}\n{_country}";
        }
    }
    public string GetAddressString()
    {
        return _addressString;
    }
}