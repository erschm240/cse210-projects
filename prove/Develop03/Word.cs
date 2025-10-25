using System.Text.RegularExpressions;

class Word
{
    // Attributes
    private string _word;
    private int _length;
    private bool _shown;
    private string _hiddenWord;

    // Constructor
    public Word(string w)
    {
        _word = w;
        _shown = true;
        _length = _word.Length;
        CreateHiddenWord();
    }

    // Behaviors
    public string Display()
    {
        if (_shown)
        {
            return " " + _word;
        }
        else
        {
            return " " + _hiddenWord;
        }
    }
    public void Hide() // setter
    {
        _shown = false;
    }
    public bool IsShown() // getter
    {
        return _shown;
    }
    private void CreateHiddenWord()
    {
        _hiddenWord = Regex.Replace(_word, "[a-zA-Z]", "_");
    }
}