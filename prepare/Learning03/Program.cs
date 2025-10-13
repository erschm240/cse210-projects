using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("====================");
        Console.WriteLine("Constructors:");
        Fraction first = new Fraction();
        Fraction second = new Fraction(6);
        Fraction third = new Fraction(6, 7);
        first.DisplayFraction();
        second.DisplayFraction();
        third.DisplayFraction();

        Console.WriteLine("====================");

        Console.WriteLine("Getters and Setters:");
        Fraction myFraction = new Fraction();
        myFraction.SetTop(6);
        myFraction.GetTop();
        myFraction.SetBottom(7);
        myFraction.GetBottom();
        myFraction.DisplayFraction();

        Console.WriteLine("====================");

        Console.WriteLine("Methods:");
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}