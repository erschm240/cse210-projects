using System.Security.Cryptography.X509Certificates;

class StartMenu
{
    // Attributes
    public List<string> _selections = new List<string>() { "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit" };
    public List<Entry> _entries = new List<Entry>();

    // Behaviors
    public void Display()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please choose an action:");

        foreach (string selection in _selections)
        {
            Console.WriteLine($"{selection}");
        }

        string userInput = "";

        do
        {
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Entry newEntry = new Entry();
                newEntry.ChoosePrompt();
                newEntry.PromptAnswer();
                _entries.Add(newEntry);
            }
            else if (userInput == "2")
            {
                foreach (Entry entry in _entries)
                {
                    Console.WriteLine(entry.DisplayEntry());
                }

            }
            else if (userInput == "3")
            {
                // Load the user's entry(ies) from a journal file
            }
            else if (userInput == "4")
            {
                // Save the user's entry(ies) to a file
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Goodbye. Have a wonderful day!");
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        } while (userInput != "5");
    }
}