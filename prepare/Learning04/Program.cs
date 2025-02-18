using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSumary());
        Console.WriteLine();

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(a2.GetSumary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSumary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}