using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("What is your birth year? ");
            birthYear = int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int userNumber)
        {
            int squaredNumber = userNumber * userNumber;
            return squaredNumber;
        }
        static void DisplayResult(string userName, int squaredNumber, int birthYear)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");

            int age = 2025 - birthYear;
            Console.WriteLine($"{userName}, you will turn {age} this year.");
        }

        static void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int birthYear;
            PromptUserBirthYear(out birthYear);
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(userName, squaredNumber, birthYear);
        }

        Main();
    }
}