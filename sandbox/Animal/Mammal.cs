class Mammal
{
    // Attributes
    protected string _name;
    protected string _sound = "";

    // Constructor
    public Mammal(string name)
    {
        _name = name;
    }
    // Behaviors
    public virtual void MakeNoise(string name)
    {
        Console.WriteLine($"{_name} makes no sound.");
    }
    public override string ToString()
    {
        return $"{this.GetType()} named {_name}";
    }
}