using System.Xml;

class Comment
{
    // Attributes
    public string _name;
    public string _text;

    // Behaviors
    public Comment(string n, string t)
    {
        _name = n;
        _text = t;
    }
    public string CreateComment()
    {
        return $"{_name}: {_text}";
    }
}