class Fox : Mammal
{
    public Fox(string name) : base(name)
    {
        _sound = "Ringa-ding-ding-ding-ringadingding";
    }
    public override void MakeNoise()
    {
        Console.WriteLine($"{name} sings {_sound}");
    }
}