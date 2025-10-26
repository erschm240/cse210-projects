using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Would you like to do Isaiah 12:2 (type 'I') or Doctrine and Covenants (type 'D') 18:10-11? ");
        string choice = Console.ReadLine().ToUpper();

        Scripture newScripture = new Scripture();
        Reference newReference = new Reference();

        if (choice == "I")
        {
            // Create the single verse scripture text and reference objects
            newScripture = new Scripture("\nBehold, God is my salvation; I will trust, and not be afraid: for the Lord JEHOVAH is my strength and my song; he also is become my salvation.");
            newReference = new Reference("Isaiah", 12, 2);
        }
        else if (choice == "D")
        {
            // Create the multi-verse scripture text and reference objects
            newScripture = new Scripture("\nRemember the worth of souls is great in the sight of God;\nFor, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him.");
            newReference = new Reference("Doctrine and Covenants", 18, 10, 11);
        }

        bool doQuit = false;

        while (!doQuit)
        {
            Console.Clear();

            // Display the scripture and reference
            Console.Write(newReference.Display());
            Console.WriteLine(newScripture.Display());

            if (newScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press enter to continue or type 'q' or 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput == "q" || userInput == "quit")
            {
                doQuit = true;
            }
            else
            {
                newScripture.HideWords();
            }
        }
    }
}