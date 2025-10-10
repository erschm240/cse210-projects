using System;

class Program
{
    static void Main(string[] args)
    {
        // To exceed requirements, I have stored the time of day and location of user (both user given) as seen in Journal.cs, Entry.cs, and when the journal program is running in the terminal.
        StartMenu startMenu = new StartMenu();
        startMenu.Display();
    }
}