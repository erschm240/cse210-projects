class Scripture
{
    // Attributes
    private string _scripture;
    private List<Word> _words = new List<Word>();
    
    // Constructors
    public Scripture()
    {
        _scripture = "";
    }
    public Scripture(string s)
    {
        _scripture = s;
        ParseText();
    }

    // Behaviors
    public void HideWords()
    {
        for (int i = 0; i < 3; i++)
        {
            Random randomWord = new Random();
            int index = randomWord.Next(_words.Count);
            bool continueWhile = true;

            while (continueWhile)
            {
                // If the word is not hidden, hide it
                if (_words[index].IsShown())
                {
                    _words[index].Hide();
                    continueWhile = false;
                }
                // If the word is hidden, move to the next available word
                else
                {
                    if (index < _words.Count - 1)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                    continueWhile = !IsCompletelyHidden();
                }
            }

            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }
    public string Display()
    {
        string scripture = "";

        foreach (Word word in _words)
        {
            scripture += word.Display();
        }

        return scripture;
    }
    private void ParseText()
    {
        List<string> words = _scripture.Split(" ").ToList<string>();
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    } 
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsShown())
            {
                return false;
            }
        }

        return true;
    }
}