using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running1 = new Running("12 Aug 2025", 35, 3);
        activities.Add(running1);
        Cycling cycling1 = new Cycling("21 Sept 2025", 90, 10);
        activities.Add(cycling1);
        Swimming swimming1 = new Swimming("15 Dec 2025", 50, 100);
        activities.Add(swimming1);

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        int count = 1;
        foreach (Activity activity in activities)
        {
            Console.WriteLine($"Exercise Activity {count}");
            Console.WriteLine(activity.GetSummary());
            if (count != activities.Count)
            {
                Console.WriteLine();
            }
            count++;
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}