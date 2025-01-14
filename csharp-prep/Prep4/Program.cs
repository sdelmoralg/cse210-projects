using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int number = 9999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {  
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            
            if (number != 0)
            {
                numbers.Add(number);

            }
        }

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        // int avg = sum / numbers.Count;
        float avg = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {avg}");

        int largest = 0;
        
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}