using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction c1 = new Fraction();
        Console.WriteLine(c1.GetTop());
        Console.WriteLine(c1.GetBottom());
        Console.WriteLine(c1.GetFractionString());
        Console.WriteLine(c1.GetDecimalValue());
        Console.WriteLine();

        Fraction c2 = new Fraction(6);
        Console.WriteLine(c2.GetTop());
        Console.WriteLine(c2.GetBottom());
        c2.SetTop(8);
        Console.WriteLine(c2.GetTop());
        Console.WriteLine(c2.GetFractionString());
        Console.WriteLine(c2.GetDecimalValue());
        Console.WriteLine();

        Fraction c3 = new Fraction(6,7);
        Console.WriteLine(c3.GetTop());
        Console.WriteLine(c3.GetBottom());
        c3.SetTop(9);
        c3.SetBottom(5);
        Console.WriteLine(c3.GetTop());
        Console.WriteLine(c3.GetBottom());
        Console.WriteLine(c3.GetFractionString());
        Console.WriteLine(c3.GetDecimalValue());
    }
}