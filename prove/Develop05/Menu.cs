class Menu
{
    // Attributes
    private int _totalPoints;
    private List<string> _options;
    private List<string> _goalOptions;
    private List<Goal> _goals;
    private string _filename;

    // Constructor
    public Menu()
    {
        _totalPoints = 0;
        _options = new List<string>() {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
        _goalOptions = new List<string>() { "Simple Goal", "Eternal Goal", "Checklist Goal" };
        _goals = new List<Goal>() {};
        _filename = "";
    }

    // Behaviors
    public void DisplayMenu()
    {
        Console.WriteLine($"You have {_totalPoints} total points.");
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
                _goals.Add(simpleGoal);
                simpleGoal.SetDisplayString();
            }

            if (goalChoice == "2")
            {
                Eternal eternalGoal = new Eternal();
                eternalGoal.Setup();
                _goals.Add(eternalGoal);
                eternalGoal.SetDisplayString();

            }

            if (goalChoice == "3")
            {
                Checklist checklistGoal = new Checklist();
                checklistGoal.Setup();
                checklistGoal.SetDisplayString();
                _goals.Add(checklistGoal);
            }
    }

    void UpdateTotalPoints()
    {
        int currentTotal = 0;
        foreach (Goal goal in _goals)
        {
            currentTotal += goal.GetPoints();
        }
        _totalPoints = currentTotal;
    }

    public void Run(string userInput)
    {
        if (userInput == "1") // Create new goal
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

        if (userInput == "2") // Display current goals
        {
            Console.WriteLine("Would you like to display all goals or only ongoing goals? ");
            Console.WriteLine("1. All Goals");
            Console.WriteLine("2. Ongoing Goals Only");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("The goals are:");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
                }
                Console.WriteLine();
            }
            if (userInput == "2")
            {
                Console.WriteLine("The goals are:");
                for (int i = 0; i < _goals.Count; i++)
                {
                    if (!_goals[i].GetState())
                    {
                        Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
                    }
                }
                Console.WriteLine();
            }
        }

        if (userInput == "3") // Save current goals to a file
        {
            Console.Write("What is the filename for the goal file? ");
            _filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                outputFile.WriteLine(_totalPoints);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine($"{goal.GetStringRepresentation()}");
                }
            }
            Console.WriteLine();
        }

        if (userInput == "4") // Load saved goals from a file
        {
            Console.Write("What is the filename for the goal file? ");
            _filename = Console.ReadLine();
            
            using (StreamReader reader = new StreamReader(_filename))
            {
                _totalPoints = int.Parse(reader.ReadLine());
            }
            string[] lines = File.ReadAllLines(_filename);
            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split("|");

                string goalType = parts[0];
                if (goalType == "Simple")
                {
                    Simple simpleGoal = new Simple();
                    simpleGoal.ReadGoal(line);
                    _goals.Add(simpleGoal);
                    simpleGoal.SetDisplayString();
                }
                if (goalType == "Eternal")
                {
                    Eternal eternalGoal = new Eternal();
                    eternalGoal.ReadGoal(line);
                    _goals.Add(eternalGoal);
                    eternalGoal.SetDisplayString();

                }
                if (goalType == "Checklist")
                {
                    Checklist checklistGoal = new Checklist();
                    checklistGoal.ReadGoal(line);
                    _goals.Add(checklistGoal);
                    checklistGoal.SetDisplayString();

                }
            }
            Console.WriteLine();
        }

        if (userInput == "5") // Record event
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }
            Console.Write("Which goal did you accomplish (type the number)? ");
            int goalNumber = int.Parse(Console.ReadLine());
            _goals[goalNumber - 1].CompleteGoal();
            UpdateTotalPoints();
            Console.WriteLine($"Congratulations! You have earned {_goals[goalNumber - 1].GetPoints()} points towards this goal!");
            Console.WriteLine($"You now have {_totalPoints} total points.");
            
            Console.WriteLine();
        }

        if (userInput == "6")
        {
            Console.WriteLine("Goodbye!");
        }
    }
}