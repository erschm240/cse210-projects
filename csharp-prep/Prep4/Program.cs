using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        double number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (number != 0)
        {
            Console.Write("Chosen number: ");
            number = double.Parse(Console.ReadLine());

            numbers.Add(number);
        }

        // Compute the sum of all numbers in the list
        double totalSum = numbers.Sum();
        Console.WriteLine($"The sum is: {totalSum}");

        // Compute the average of the list
        double totalNums = numbers.Count;
        double average = 0;
        if (totalNums - 1 != 0)
        {
            average = totalSum / (totalNums - 1);
        }
        
        Console.WriteLine($"The average is: {average}");

        // Find the largest number in the list
        double maxNum = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNum}");
    }
}