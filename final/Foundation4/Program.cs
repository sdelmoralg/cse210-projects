using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n------------------------------------\n");

        Activity swimming = new Swimming(new DateTime(2025, 11, 03), 60, 30);
        Console.WriteLine(swimming.GetSummary());
       
        Console.WriteLine("\n------------------------------------\n");

        Activity running = new Running(new DateTime(2025, 03, 02), 90, 5);
        Console.WriteLine(running.GetSummary());

        Console.WriteLine("\n------------------------------------\n");

        Activity cycling = new Cycling(new DateTime(2025, 02, 23), 126, 16);
        Console.WriteLine(cycling.GetSummary());

        Console.WriteLine("\n------------------------------------\n");

        // to do - Put each of these activities in the same list. Then iterate through this
        // list and call the GetSummary method on each item and display the results.


    }
}