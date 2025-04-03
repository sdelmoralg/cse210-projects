using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 03, 02), 90, 5),
            new Cycling(new DateTime(2025, 02, 23), 126, 16),
            new Swimming(new DateTime(2025, 11, 03), 60, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}\n");
        }

        // Put each of these activities in the same list. Then iterate through this
        // list and call the GetSummary method on each item and display the results.


    }
}