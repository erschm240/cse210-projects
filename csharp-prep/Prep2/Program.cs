using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for grade percentage
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        // Convert user string to an integer
        int percentage = int.Parse(grade);

        string letter = "";

        // Evaluate the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter grade earned
        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"You earned an {letter} in this class.");
        }
        else
        {
            Console.WriteLine($"You earned a {letter} in this class.");
        }

        // Evaluate if the user passed the class
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You did not pass, but with practice I'm sure you can do it!");
        }
    }
}