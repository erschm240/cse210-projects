using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        // To exceed requirements I added a display feature that allows the user to view all goals or only the goals that are ongoing, and hide the ones that have been completed. The ongoing-only list also keeps the list number originally assigned to a goal instead of reassigning a list number.
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