class Event
{
    // Attributes
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    protected string _standardMessage;

    // Behaviors
    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address.GetAddressString();
    }
    public void SetStandardMessage()
    {
        _standardMessage = $"{_title}\n{_description}\n{_date} @ {_time}\n{_address}";
    }
    public string StandardMessage()
    {
        return _standardMessage;
    }
    public string ShortMessage()
    {
        return $"{this.GetType()} Event\n{_title}\n{_date}";
    }
    public virtual string FullMessage()
    {
        return "";
    }
    public void DisplayEvents(Event currentEvent)
    {
        currentEvent.SetStandardMessage();
        Console.WriteLine("Standard Message:");
        Console.WriteLine(currentEvent.StandardMessage());
        Console.WriteLine();
        Console.WriteLine("Short Message:");
        Console.WriteLine(currentEvent.ShortMessage());
        Console.WriteLine();
        Console.WriteLine("Full Message:");
        Console.WriteLine(currentEvent.FullMessage());
        Console.WriteLine();
    }
}