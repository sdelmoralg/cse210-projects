using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Yorktown Road", "Yorktown", "VA", "USA");
        Event lecture = new Lecture("Food Storage", "Learn how to start your food storage", "April 12, 2025", "10 am", address1, "Sarah Brown", 80);

        Console.WriteLine(lecture.FullDetails());
        
    }
}