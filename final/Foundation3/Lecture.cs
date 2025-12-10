class Lecture : Event
{
    // Attributes
    private string _speaker;
    private int _capacity;

    // Behaviors
    public Lecture(string title, string desc, string date, string time, Address address, string speaker, int capacity) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string FullMessage()
    {
        return $"{this.GetType()} Event\n{_standardMessage}\n{_speaker} will be speaking.\nCapacity: {_capacity}";
    }
}