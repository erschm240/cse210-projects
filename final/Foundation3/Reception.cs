class Reception : Event
{
    // Attributes
    private string _rsvpInfo;

    // Behaviors
    public Reception(string title, string desc, string date, string time, Address address, string rsvp) : base(title, desc, date, time, address)
    {
        _rsvpInfo = rsvp;
    }

    public override string FullMessage()
    {
        return $"{this.GetType()} Event\n{_standardMessage}\nIf you are coming, please RSVP to {_rsvpInfo}.";
    }
}