class Checklist : Goal
{
    // Attributes
    private int _completionTracker;
    private int _completionTotal;
    private int _bonusPoints;

    // Constructor
    public Checklist() : base()
    {
        _completionTracker = 0;
        _completionTotal = 0;
        _bonusPoints = 0;
        _completed = false;
    }

    // Behaviors
    public override void Setup()
    {
        base.Setup();
        Console.Write("How many times should this goal be accomplished for a bonus? ");
        _completionTotal = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points is it worth to do this that amount of times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override string GetStringRepresentation()
    {
        return $"{this.GetType()}|{_name}|{_description}|{_points}|{_completed}|{_bonusPoints}|{_completionTracker}|{_completionTotal}";
    }

    public override void SetDisplayString()
    {
        string completedString = " ";
        if (_completionTracker == _completionTotal)
        {
            completedString = "X";
            _completed = true;
        }
        _displayString = $"[{completedString}] {_name} ({_description}) -- Currently Completed: {_completionTracker}/{_completionTotal}";
    }

    public override int GetPoints()
    {
        int fullPoints = _points * _completionTracker;
        if (_completionTracker == _completionTotal)
        {
            fullPoints += _bonusPoints;
        }
        return fullPoints;
    }

    public override string CompleteGoal()
    {
        if (_completionTracker != _completionTotal)
        {
            _completionTracker++;
        }
        SetDisplayString();
        return GetDisplayString();
    }

    public override void ReadGoal(string line)
    {
        string[] columns = line.Split('|');
        if (columns.Length == 8)
        {
            base.ReadGoal($"{columns[0]}|{columns[1]}|{columns[2]}|{columns[3]}|{columns[4]}");
            _bonusPoints = int.Parse(columns[5]);
            _completionTracker = int.Parse(columns[6]);
            _completionTotal = int.Parse(columns[7]);
        }
    }
}