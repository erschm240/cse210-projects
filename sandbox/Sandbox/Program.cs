using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string randomWords = "hello sandbox world!";
        TextInfo textinfo = CultureInfo.CurrentCulture.TextInfo;
        string capitalized = textinfo.ToTitleCase(randomWords);
        Console.WriteLine(capitalized);
    }
}