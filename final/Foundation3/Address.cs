using System.Data;

class Address
{
    // Attributes
    private string _streetAddress;
    private string _city;
    private string _state;
    protected string _addressString;

    //Behaviors
    public Address(string street, string city, string state)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _addressString = $"{_streetAddress}\n{_city}, {_state}";
    }
    public string GetAddressString()
    {
        return _addressString;
    }
}