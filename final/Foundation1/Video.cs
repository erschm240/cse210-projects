class Video
{
    // Attributes
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    // Behaviors
    public Video(string t, string a, int l)
    {
        _title = t;
        _author = a;
        _length = l;
    }
    public string CreateVideoString()
    {
        return $"{_title} by {_author}\nDuration: {_length * 60} seconds";
    }

    public void DisplayVideo()
    {
        Console.WriteLine(CreateVideoString());
        Console.WriteLine();
        Console.WriteLine($"Number of comments: {_comments.Count()}");
        GetComments();
    }

    public void GetComments()
    {
        int count = 1;
        foreach (Comment comment in _comments)
        {
            string commentString = comment.CreateComment();
            Console.WriteLine($"{count}. {commentString}");
            count++;
        }
    }
}