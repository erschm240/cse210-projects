using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        // Console.Write("What is the magic number? ");
        // string numberInput = Console.ReadLine();
        // int magicNumber = int.Parse(numberInput);

        int guess = -1;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);
    }
}