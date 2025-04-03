using System;

class Program
{
    static void Main(string[] args)
    {
        Activity swimming = new Swimming(new DateTime(2025, 11, 03), 60, 30);

        Console.WriteLine(swimming.GetSummary());
    }
}