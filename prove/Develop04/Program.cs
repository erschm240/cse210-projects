using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        // To exceed requirements, I have kept a log of how many times each activity was completed as well as the total amount. This data is displayed after the user ends their session.
        Breathing breathingActivity = new Breathing();
        Reflecting reflectingActivity = new Reflecting();
        Listing listingActivity = new Listing();
        List<string> options = new List<string> { "Start Breathing Activity", "Start Reflecting Activity", "Start Listing Activity", "Quit" };

        string userInput = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App");
            Console.WriteLine();
            Console.WriteLine("Activity Options:");

            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            Console.Write("\nPlease choose an option: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Clear();
                Console.Write("\x1b[3J"); // Clears code stuck in the scrollback buffer
                Console.Write(breathingActivity.WelcomeMsg());
                breathingActivity.SetTime();

                Console.Clear();
                breathingActivity.InitializeActivity();
                breathingActivity.StartBreathing();

                breathingActivity.EndMsg();
                breathingActivity.ExitActivity();
                Console.Clear();
                Console.WriteLine("\x1b[3J");
            }

            else if (userInput == "2")
            {
                Console.Clear();
                Console.Write("\x1b[3J");
                Console.Write(reflectingActivity.WelcomeMsg());
                reflectingActivity.SetTime();

                Console.Clear();
                reflectingActivity.InitializeActivity();
                reflectingActivity.StartReflecting();

                reflectingActivity.EndMsg();
                reflectingActivity.ExitActivity();
                Console.Clear();
                Console.WriteLine("\x1b[3J");
            }

            else if (userInput == "3")
            {
                Console.Clear();
                Console.Write("\x1b[3J");
                Console.Write(listingActivity.WelcomeMsg());
                listingActivity.SetTime();

                Console.Clear();
                listingActivity.InitializeActivity();
                listingActivity.StartListing();

                listingActivity.EndMsg();
                listingActivity.ExitActivity();
                Console.Clear();
                Console.WriteLine("\x1b[3J");
            }

            else if (userInput == "4")
            {
                Console.Clear();
                Console.WriteLine("Activities completed this session:");
                Console.WriteLine($"Breathing: {breathingActivity.GetAmountPerformed()}");
                Console.WriteLine($"Reflecting: {reflectingActivity.GetAmountPerformed()}");
                Console.WriteLine($"Listing: {listingActivity.GetAmountPerformed()}");
                Console.WriteLine($"Total: {breathingActivity.GetAmountPerformed() + reflectingActivity.GetAmountPerformed() + listingActivity.GetAmountPerformed()}");

                Console.WriteLine();
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.Write("Invalid input, please try again. ");
                Thread.Sleep(1000);
            }
        } while (userInput != "4");
    }
}