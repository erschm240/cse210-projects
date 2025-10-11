using System.Security.Cryptography.X509Certificates;

class StartMenu
{
    // Attributes
    public List<string> _selections = new List<string>() { "1. Write", "2. Display", "3. Save", "4. Load", "5. Quit" };

    // Behaviors
    public void Display()
    {
        Journal myJournal = new Journal();
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
                Entry newEntry = new Entry(myJournal.ChoosePrompt());
                newEntry.PromptAnswer();
                myJournal._entries.Add(newEntry);
            }
            else if (userInput == "2")
            {
                foreach (Entry entry in myJournal._entries)
                {
                    Console.WriteLine(entry.DisplayEntry());
                }

            }
            else if (userInput == "3")
            {
                myJournal.WriteToFile();
            }
            else if (userInput == "4")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.ReadFromFile(filename);
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