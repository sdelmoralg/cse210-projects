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

    }
}