class Goal
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;
    protected string _displayString;

    // Constructor
    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _completed = false;
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

    public virtual void SetDisplayString()
    {
        _displayString = $"[ ] {_name} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{this.GetType()}|{_name}|{_description}|{_points}|{_completed}";
    }

    public string GetDisplayString()
    {
        return _displayString;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public virtual bool GetState()
    {
        return _completed;
    }

    public virtual string CompleteGoal()
    {
        _displayString = $"[X] {_name} ({_description})";
        return _displayString;
    }

    public virtual void ReadGoal(string line)
    {
        string[] columns = line.Split('|');
        if (columns.Length == 5)
        {
            _name = columns[1];
            _description = columns[2];
            _points = int.Parse(columns[3]);
            _completed = bool.Parse(columns[4]);
        }
    }
}