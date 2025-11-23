class Menu
{
    // Attributes
    private int _totalPoints;
    private List<string> _options;
    private List<string> _goalOptions;
    private List<Goal> _goals;
    private List<string> _goalsDisplay;
    private string _filename;

    // Constructor
    public Menu()
    {
        _totalPoints = 0;
        _options = new List<string>() {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
        _goalOptions = new List<string>() { "Simple Goal", "Eternal Goal", "Checklist Goal" };
        _goals = new List<Goal>() {};
        _goalsDisplay = new List<string>() {};
        _filename = "";
    }

    // Behaviors
    public void DisplayMenu()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        for (int i = 0; i < _options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_options[i]}");
        }
        Console.Write("Select a choice from the menu: ");
    }

    void ChooseGoal(string goalChoice)
    {
        if (goalChoice == "1")
            {
                Simple simpleGoal = new Simple();
                simpleGoal.Setup();
                string formattedGoal = simpleGoal.DisplayFormat();
                _goalsDisplay.Add(formattedGoal);
                _goals.Add(simpleGoal);
            }

            if (goalChoice == "2")
            {
                Eternal eternalGoal = new Eternal();
                eternalGoal.Setup();
                string formattedGoal = eternalGoal.DisplayFormat();
                _goalsDisplay.Add(formattedGoal);
                _goals.Add(eternalGoal);

            }

            if (goalChoice == "3")
            {
                Checklist checklistGoal = new Checklist();
                checklistGoal.Setup();
                string formattedGoal = checklistGoal.DisplayFormat();
                _goalsDisplay.Add(formattedGoal);
                _goals.Add(checklistGoal);
            }
    }

    public void Run(string userInput)
    {
        if (userInput == "1")
        {
            Console.WriteLine("The types of goals are: ");
            for (int i = 0; i < _goalOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goalOptions[i]}");
            }
            Console.Write("Which type of goal would you like to create? ");
            string goalChoice = Console.ReadLine();
            Console.WriteLine("");
            ChooseGoal(goalChoice);
            Console.WriteLine();
        }

        if (userInput == "2")
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
            }
            Console.WriteLine();
        }

        if (userInput == "3")
        {
            Console.WriteLine();
        }

        if (userInput == "4")
        {
            Console.WriteLine();
        }

        if (userInput == "5")
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }
            Console.Write("Which goal did you accomplish? ");
            int goalNumber = int.Parse(Console.ReadLine());
            _goals[goalNumber].CompleteGoal();
            
            Console.WriteLine();
        }

        if (userInput == "6")
        {
            Console.WriteLine("Goodbye!");
        }
    }
}