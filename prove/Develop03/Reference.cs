class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;
    private string _fullReference;

    //Constructors
    public Reference() // Create a reference without any specific values
    {
        _book = "";
        _chapter = 0;
        _verse = 0;
        _verseEnd = 0;
    }
    public Reference(string b, int c, int v) // Create a single verse reference
    {
        _book = b;
        _chapter = c;
        _verse = v;
        BuildSingleReference();
    }

    public Reference(string b, int c, int v, int e) // Create a multi-verse reference
    {
        _book = b;
        _chapter = c;
        _verse = v;
        _verseEnd = e;
        BuildMultiReference();
    }

    //Behaviors
    private void BuildSingleReference() // Build the string for the single verse reference
    {
        _fullReference = $"{_book} {_chapter}:{_verse}";
    }
    private void BuildMultiReference() // Build the string for the multi-verse reference
    {
        _fullReference = $"{_book} {_chapter}:{_verse}-{_verseEnd}";
    }

    public string Display()
    {
        return _fullReference;
    }
}