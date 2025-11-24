class Simple : Goal
{
    // Attributes

    // Constructor
    public Simple() : base()
    {
        _completed = false;
    }

    // Behaviors
    public override void Setup()
    {
        base.Setup();
    }

    public override void SetDisplayString()
    {
        string completedString = " ";
        if (_completed)
        {
            completedString = "X";
        }
        _displayString = $"[{completedString}] {_name} ({_description})";
    }

    public override int GetPoints()
    {
        if (_completed)
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override string CompleteGoal()
    {
        _completed = true;
        SetDisplayString();
        return GetDisplayString();
    }
}