class Activity
{
    // Attributes
    protected string _date;
    protected double _length;

    //Behaviors
    public Activity(string d, double l)
    {
        _date = d;
        _length = l;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{_date} {this.GetType()} ({_length} min) - Distance: {this.GetDistance()} miles, Speed: {this.GetSpeed()} mph, {this.GetPace()} min per mile";
    }
}