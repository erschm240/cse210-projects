class Reflecting : Activity
{
    //Attributes
    // private int _amountReflectingPerformed;

    List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you faced a fear.",
        "Think of a time when you learned from a mistake.",
        "Think of a time when you persevered through a trial.",
        "Think of a time when you learned something new about yourself."
    };
    List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    
    // Constructor
    public Reflecting() : base(
        "Reflecting",
        "Welcome to the Reflecting Activity.\n",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in  other aspects of your life. "
    )
    {
        _totalActivitiesPerformed = 0;
    }
    
    // Behaviors
    public void StartReflecting()
    {
        Console.Clear();

        Random randNum = new Random();
        int index = randNum.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as the relate to this experience.");
        Console.WriteLine();
        Console.Write("You may begin this experience in: ");
        CountDown(9);
        Console.WriteLine();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            index = randNum.Next(_questions.Count);
            string question = _questions[index];
            Console.Write($"> {question} ");
            ArrowAnimation(10);
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}