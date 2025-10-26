using System;

class Program
{
    static void Main(string[] args)
    {
        // To exceed requirements, I have preserved the punctuation when words are hidden, only hide words that aren't already hidden, and I have printed the hidden underscores to match the length of the word it's replacing.

        // Ask the user which scripture they would like to memorize
        Console.Write("Would you like to do Isaiah 12:2 (type 'I') or Doctrine and Covenants 18:10-11 (type 'D')? ");
        string choice = Console.ReadLine().ToUpper();

        // Create empty scripture and reference objects
        Scripture newScripture = new Scripture();
        Reference newReference = new Reference();

        if (choice == "I")
        {
            // Populate the objects with the single verse scripture
            newScripture = new Scripture("\nBehold, God is my salvation; I will trust, and not be afraid: for the Lord JEHOVAH is my strength and my song; he also is become my salvation.");
            newReference = new Reference("Isaiah", 12, 2);
        }
        else if (choice == "D")
        {
            // Populate the objects with the multi-verse scripture
            newScripture = new Scripture("\nRemember the worth of souls is great in the sight of God;\nFor, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him.");
            newReference = new Reference("Doctrine and Covenants", 18, 10, 11);
        }

        // Variable to allow the program to enter the loop
        bool doQuit = false;

        // 
        while (!doQuit)
        {
            Console.Clear();

            // Display the scripture and reference
            Console.Write(newReference.Display());
            Console.WriteLine(newScripture.Display());

            // If the scripture is hidden, leave the loop
            if (newScripture.IsCompletelyHidden())
            {
                break;
            }

            // Proceeding and quitting instructions, as well as what should happen for either
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