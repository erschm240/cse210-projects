public class MathAssignment : Assignment
{
    // Attributes
    private string _textbookSection;
    private string _problems;

    // Constructor
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    // Behaviors
    public string GetHomeworkList()
    {
        string homework = $"Section {_textbookSection} Problems {_problems}";
        return homework;
    }
}