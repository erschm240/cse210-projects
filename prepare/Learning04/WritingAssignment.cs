class WritingAssignment : Assignment
{
    // Attributes
    private string _title;

    // Constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    // Behaviors
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        string information = $"{_title} by {studentName}";
        return information;
    }
}