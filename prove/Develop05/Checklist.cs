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
    }
    public Checklist(string name, string desc, int points, int total, int bonus) : base(name, desc, points)
    {
        _completionTracker = 0;
        _completionTotal = total;
        _bonusPoints = bonus;
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
        return $"{this.GetType()}|{_name}|{_description}|{_points}|{_completionTracker}|{_completionTotal}";
    }

    public override string DisplayFormat()
    {
        string _displayString = $"[ ] {_name} ({_description}) -- Currently Completed: {_completionTracker}/{_completionTotal}";
        return _displayString;
    }

    public override string CompleteGoal()
    {
        if (_completionTracker == _completionTotal)
        {
        _displayString = $"[X] {_name} ({_description}) -- Currently Completed: {_completionTracker}/{_completionTotal}";
        }
        else
        {
            _completionTracker += 1;
            _displayString = $"[ ] {_name} ({_description}) -- Currently Completed: {_completionTracker}/{_completionTotal}";
        }
        return _displayString;
    }
}