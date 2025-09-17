using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Get user last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Write full name to console in James Bond style
        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
    }
}