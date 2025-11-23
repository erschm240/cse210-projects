class Simple : Goal
{
    // Attributes
    private bool _completed;

    // Constructor
    public Simple() : base()
    {
        _completed = false;
    }
    public Simple(string name, string desc, int points) : base(name, desc, points)
    {
        _completed = false;
    }

    // Behaviors
    public override void Setup()
    {
        base.Setup();
    }
    public bool GetState()
    {
        return _completed;
    }

    public override string GetStringRepresentation()
    {
        return $"{this.GetType()}|{_name}|{_description}|{_points}|{_completed}";
    }

    public override string DisplayFormat()
    {
        _displayString = $"[ ] {_name} ({_description})";
        return _displayString;
    }

    public override string CompleteGoal()
    {
        _completed = true;
        _displayString = $"[X] {_name} ({_description})";
        return _displayString;
    }
}