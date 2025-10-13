class Bin
{
    // Attributes
    private string _denomination;
    private double _value;
    private int _count;

    // Behaviors
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }
    // Modifier method "Alter" method
    public void Alter(int delta)
    {
        _count += delta;
    }
    // Accessor "getter" methods
    public string GetDenomination()
    {
        return _denomination;
    }
    public int GetCount()
    {
        return _count;
    }
}