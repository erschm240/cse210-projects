using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Menu menu = new Menu();
        do
        {
            menu.DisplayMenu();
            userInput = Console.ReadLine();
            Console.WriteLine();
            menu.Run(userInput);
        } while (userInput != "6");
    }
}