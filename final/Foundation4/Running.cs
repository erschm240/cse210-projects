class Running : Activity
{
    // Attributes
    private double _distance;

    // Behaviors
    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return Math.Round(_distance, 1);
    }
    public override double GetSpeed()
    {
        return Math.Round(_distance / _length * 60, 1);
    }
    public override double GetPace()
    {
        return Math.Round(_length / _distance, 1);
    }
}