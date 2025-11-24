class Eternal : Goal
{
    // Attributes
    private int _completionTracker;
    // Constructor
    public Eternal() : base()
    {
        _completionTracker = 0;
    }

    // Behaviors
    public override void Setup()
    {
        base.Setup();
        _completionTracker = 0;
    }

    public override string GetStringRepresentation()
    {
        return $"{this.GetType()}|{_name}|{_description}|{_points}|{_completed}|{_completionTracker}";
    }

    public override void ReadGoal(string line)
    {
        string[] columns = line.Split('|');
        if (columns.Length == 6)
        {
            base.ReadGoal($"{columns[0]}|{columns[1]}|{columns[2]}|{columns[3]}|{columns[4]}");
            _completionTracker = int.Parse(columns[5]);
        }
    }

    public override int GetPoints()
    {
        return _points * _completionTracker;
    }

    public override string CompleteGoal()
    {
        _completionTracker++;
        _displayString = $"[ ] {_name} ({_description})";
        return _displayString;
    }
}