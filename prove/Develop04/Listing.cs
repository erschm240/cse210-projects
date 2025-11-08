using System.Diagnostics;

class Listing : Activity
{
    // Attributes
    // private int _amountListingPerformed;

    List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor
    public Listing() : base(
        "Listing",
        "Welcome to the Listing Activity.\n",
        "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area."
    )
    {
        _totalActivitiesPerformed = 0;
    }
    
    // Behaviors
    public void StartListing()
    {
        Console.Clear();

        Random randNum = new Random();
        int index = randNum.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin this experience in: ");
        CountDown(9);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int listCount = 0;
        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            listCount += 1;
        }

        Console.WriteLine($"You listed {listCount} items!");
        Console.WriteLine();
    }
}