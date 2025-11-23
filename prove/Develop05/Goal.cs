class Goal
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _displayString;

    // Constructor
    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
    }
    public Goal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _points = points;
    }

    // Behaviors
    public virtual void Setup()
    {
        Console.Write("Enter a name for this goal: ");
        _name = Console.ReadLine();
        Console.Write("Enter a description of this goal: ");
        _description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        _points = int.Parse(Console.ReadLine());
    }
    public virtual string DisplayFormat()
    {
        _displayString = $"[ ] {_name} ({_description})";
        return _displayString;
    }

    public virtual string GetStringRepresentation()
    {
        return $"{this.GetType()}|{_name}|{_description}|{_points}";
    }

    public string GetDisplayString()
    {
        return _displayString;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual void SetPoints(int points)
    {
        _points = points;
    }

    public virtual string CompleteGoal()
    {
        _displayString = $"[X] {_name} ({_description})";
        return _displayString;
        
    }

    public virtual void ReadGoal()
    {
        
    }

    public virtual void WriteGoal()
    {
        
    }
}