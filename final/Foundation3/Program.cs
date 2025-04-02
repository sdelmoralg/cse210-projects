using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Yorktown Road", "Yorktown", "VA", "USA");
        Event lecture = new Lecture("Food Storage", "Learn how to start your food storage", "April 12, 2025", "10:00 am", address1, "Sarah Brown", 80);

        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine(lecture.ShortDetails());
        Console.WriteLine();

        Address address2 = new Address("35 Whyte Creek", "Oddessa", "TX", "USA");
        Event reception = new Reception("Andrea's XV años", "Come celebrate with Andrea her XV primaveras", "Oct 15, 2025", "8:00 pm", address2, "andreasxv@gmail.com");

        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine(reception.ShortDetails());
        Console.WriteLine();
        
    }
}