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
    public void Hide() // Set shown state of word to hide it
    {
        _shown = false;
    }
    public bool IsShown() // Get the state of the word
    {
        return _shown;
    }
    private void CreateHiddenWord() // Create the underscore version of the word, leaving any non-letter characters alone
    {
        _hiddenWord = Regex.Replace(_word, "[a-zA-Z]", "_");
    }
}