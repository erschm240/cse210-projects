public class Assignment
{
    // Attributes
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    // Behaviors
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}