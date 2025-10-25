using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture text and reference objects
        Scripture singleScripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Reference singleReference = new Reference("John", 3, 16);

        bool doQuit = false;

        while (!doQuit)
        {
            Console.Clear();

            // Display the scripture and reference
            Console.Write(singleReference.Display());
            Console.WriteLine(singleScripture.Display());

            if (singleScripture.IsCompletelyHidden())
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
                singleScripture.HideWords();
            }
        }
    }
}