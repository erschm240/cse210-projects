class Entry
{
    // Attributes
    public List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?" };
    public List<string> _entries = new List<string>();
    public string _date = "10-6-2025";
    // Behaviors
    public void ChoosePrompt()
    {
        Console.WriteLine($"{_prompts[1]}");
        Console.Write(">> ");
        string userEntry = Console.ReadLine();

        // newEntry._entries.Add(userEntry);
        // Console.WriteLine(_entries);
    }
}