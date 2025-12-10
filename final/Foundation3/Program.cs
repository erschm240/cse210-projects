using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        
        Address lectureAddress = new Address("457 W Broadway Street", "Idaho Falls", "ID");
        Lecture spellLecture = new Lecture("Principles of Spell-Casting", "Learn how to cast spells in this fantastical lecture.", "October 31, 2026", "4:30 pm", lectureAddress, "Gandalf", 600);
        events.Add(spellLecture);
        
        Address receptionAddress = new Address("4402 N Central Avenue", "Phoenix", "AZ");
        Reception lizardReception = new Reception("Leonard's Birthday Party", "Come and celebrate the 5th birthday of Leonard the bearded dragon.", "December 29, 2025", "6:00 pm", receptionAddress, "lizardowner@yahoo.com");
        events.Add(lizardReception);
        
        Address outdoorAddress = new Address("7695 Bellevue Drive", "Soho", "NY");
        Outdoor droneOutdoor = new Outdoor("Greek Festival Drone Show", "Watch famous mythical Greek figures like Circe and Odysseus fly across the sky at the Greek Mythology festival.", "June 5, 2026", "11:00 pm", outdoorAddress, "clear skies with a slight breeze");
        events.Add(droneOutdoor);
        
        int count = 1;
        foreach (Event currentEvent in events)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Event {count}");
            Console.WriteLine();
            currentEvent.DisplayEvents(currentEvent);
            count++;
        }
    }
}