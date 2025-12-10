class Outdoor : Event
{
    // Attributes
    private string _weather;

    // Behaviors
    public Outdoor(string title, string desc, string date, string time, Address address, string weather) : base(title, desc, date, time, address)
    {
        _weather = weather;
    }

    public override string FullMessage()
    {
        return $"{this.GetType()} Event\n{_standardMessage}\nThe weather is forecasted to be {_weather}.";
    }
}