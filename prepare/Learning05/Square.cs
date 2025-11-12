class Square : Shape
{
    // Attributes
    private double _side;
    // Behaviors
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}