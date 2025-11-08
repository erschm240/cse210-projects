class Breathing : Activity
{
    // Constructor
    public Breathing() : base(
        "Breathing",
        "Welcome to the Breathing Activity.\n",
        "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing."
    )
    {
        _totalActivitiesPerformed = 0;
    }

    // Behaviors
    public void StartBreathing()
    {
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> Breathe in through your nose... ");
            ArrowAnimation(5);
            Console.WriteLine();

            Console.Write("> And out through your mouth... ");
            ArrowAnimation(5);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}