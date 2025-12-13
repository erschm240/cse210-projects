class Cycling : Activity
{
    // Attributes
    private double _speed;

    // Behaviors
    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return GetSpeed() * (_length / 60);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}