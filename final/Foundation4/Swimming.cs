class Swimming : Activity
{
    // Attributes
    private double _laps;

    // Behaviors
    public Swimming(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50  / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / _length * 60, 1);
    }
    public override double GetPace()
    {
        return Math.Round(_length / GetDistance(), 1);
    }
}