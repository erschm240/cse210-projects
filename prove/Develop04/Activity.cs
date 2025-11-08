class Activity
{
    // Attributes
    protected int _duration;
    private string _name;
    private string _title;
    private string _description;
    protected int _totalActivitiesPerformed;

    // Constructor
    public Activity(string activityName, string activityTitle, string activityDesc)
    {
        _duration = 0;
        _name = activityName;
        _title = activityTitle;
        _description = activityDesc;
        _totalActivitiesPerformed = 0;
    }

    // Behaviors
    public void SetTime()
    {
        Console.Write("\nHow long would you like the activity to last (in seconds)? ");
        int userDuration = int.Parse(Console.ReadLine());
        _duration = userDuration;
    }
    public void InitializeActivity()
    {
        Console.Write("Starting activity... ");
        ArrowAnimation(5);
        Console.WriteLine();
    }
    public string WelcomeMsg()
    {
        string title = _title;
        string description = _description;
        return $"\n{title}\n{description}\n";
    }
    public void EndMsg()
    {
        _totalActivitiesPerformed += 1;
        Console.WriteLine();
        Console.Write("Great job! ");
        ArrowAnimation(5);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    }
    public void ExitActivity()
    {
        Console.Write("Exiting activity... ");
        ArrowAnimation(5);
    }
    public void ArrowAnimation(int duration)
    {
        List<string> animationStrings = new List<string>()
        {
            "[->    ]",
            "[ ->   ]",
            "[  ->  ]",
            "[   -> ]",
            "[    ->]",
            "[    <-]",
            "[   <- ]",
            "[  <-  ]",
            "[ <-   ]",
            "[<-    ]"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b"); // 10 spaces between each group of "\b"

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void CountDown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetAmountPerformed()
    {
        return _totalActivitiesPerformed;
    }
}