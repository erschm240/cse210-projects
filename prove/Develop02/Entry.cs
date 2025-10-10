
using System.Globalization;
class Entry
{
    // Attributes
    public string _text;
    public string _date;
    public string _prompt;
    public string _time;
    public string _location;

    // Constructors
    public Entry()
    {
        _text = "";
        _date = "";
        _prompt = "";
        _time = "";
        _location = "";
    }
    public Entry(string prompt)
    {
        _text = "";
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _time = "";
        _location = "";
    }

    // Behaviors
    public void PromptAnswer()
    {
        TextInfo myTI = CultureInfo.CurrentCulture.TextInfo;
        Console.Write(">> ");
        _text = Console.ReadLine();
        Console.WriteLine("What time of day are you writing this (morning, evening, etc.)? ");
        Console.Write(">> ");
        _time = myTI.ToTitleCase(Console.ReadLine());
        Console.WriteLine("Where are you writing this from, to provide some context? ");
        Console.Write(">> ");
        _location = myTI.ToTitleCase(Console.ReadLine());
    }

    public string DisplayEntry()
    {
        return string.Format("========================================\nWritten {0}, {1}, at {2} \n----------------------------------------\nPrompt: {3} \nMy Answer: {4}", _date, _time, _location, _prompt, _text);
    }

    public string WriteEntry()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", _date, _time, _location, _prompt, _text);
    }

    public void ReadEntry(string line)
    {
        string[] columns = line.Split('|');
        if (columns.Length == 5)
        {
            _date = columns[0];
            _time = columns[1];
            _location = columns[2];
            _prompt = columns[3];
            _text = columns[4];
        }
    }
}