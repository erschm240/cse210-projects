class Scripture
{
    // Attributes
    private string _scripture;
    private List<Word> _words = new List<Word>();
    
    // Constructors
    public Scripture() // Build a scripture without a specific value
    {
        _scripture = "";
    }
    public Scripture(string s) // Build the string for the scripture text
    {
        _scripture = s;
        ParseText();
    }

    // Behaviors
    public void HideWords() // Hide words
    {
        // Only hide three words
        for (int i = 0; i < 3; i++)
        {
            // Select a random index of a word
            Random randomWord = new Random();
            int index = randomWord.Next(_words.Count);
            // Variable to allow the program to enter the loop
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
            // If all words are hidden, leave loop
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }
    public string Display() // Build the scripture string that is displayed to the screen at start and at every reload
    {
        string scripture = "";

        foreach (Word word in _words)
        {
            scripture += word.Display();
        }

        return scripture;
    }
    private void ParseText() // Create the list that will contain each word individually for the hide method
    {
        List<string> words = _scripture.Split(" ").ToList<string>();
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    } 
    public bool IsCompletelyHidden() // Check if each word is hidden or shown, only return true when all are hidden
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