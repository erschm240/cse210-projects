class Entry
{
    // Attributes
    public List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?" };
    public string _text = "";
    public string _date = "10-6-2025";

    public string _prompt = "";
    // Behaviors
    public void ChoosePrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        _prompt = _prompts[index];
        Console.WriteLine($"{_prompt}");
    }

    public void PromptAnswer()
    {
        Console.Write(">> ");
        _text = Console.ReadLine();
        _date = DateTime.Now.ToShortDateString();
    }

    public string DisplayEntry()
    {
        return string.Format("{0} {1}: {2}", _date, _prompt, _text);
        
    }
}