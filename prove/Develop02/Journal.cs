using System.IO;
using System.Reflection.Metadata;

class Journal
{
    // Attributes
    public List<Entry> _entries;
    public string _filename;
    public List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I learned today?" };

    // Constructors
    public Journal()
    {
        _entries = new List<Entry>();
        _filename = "";

    }

    // Behaviors
    public string ChoosePrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"{prompt}");
        return prompt;
    }
    public void WriteToFile()
    {
        Console.WriteLine("What is the filename? ");
        _filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry.WriteEntry()}");
                }
            }
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            newEntry.ReadEntry(line);
            Console.WriteLine(newEntry.DisplayEntry());
        }
    }
}