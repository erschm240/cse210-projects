class Rectangle : Shape
{
    // Attributes
    private double _width;
    private double _length;
    // Behaviors
    public Rectangle(string color, double width, double length) : base(color)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        double area = _width * _length;
        return area;
    }
}