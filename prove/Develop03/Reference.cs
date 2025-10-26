class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;
    private string _fullReference;

    //Constructors
    public Reference()
    {
        _book = "";
        _chapter = 0;
        _verse = 0;
        _verseEnd = 0;
    }
    public Reference(string b, int c, int v)
    {
        _book = b;
        _chapter = c;
        _verse = v;
        BuildSingleReference();
    }

    public Reference(string b, int c, int v, int e)
    {
        _book = b;
        _chapter = c;
        _verse = v;
        _verseEnd = e;
        BuildMultiReference();
    }

    //Behaviors
    private void BuildSingleReference()
    {
        _fullReference = $"{_book} {_chapter}:{_verse}";
    }
    private void BuildMultiReference()
    {
        _fullReference = $"{_book} {_chapter}:{_verse}-{_verseEnd}";
    }

    public string Display()
    {
        return _fullReference;
    }
}