class Tiger
{
    public Tiger(string name) : base(name)
    {
        _sound = growl;
    }
    public override void MakeNoise()
    {
        Console.WriteLine($"{name} says {_sound}");
    }
}