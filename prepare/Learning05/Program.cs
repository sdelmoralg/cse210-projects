using System;
using System.Drawing;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        // Square s = new Square("green", 4);
        // Console.WriteLine($"\nSquare Color: {s.GetColor()}");
        // Console.WriteLine($"Square Area: {s.GetArea():F2}");

        // Rectangle r = new Rectangle("blue", 6, 4);
        // Console.WriteLine($"\nRectangle color: {r.GetColor()}");
        // Console.WriteLine($"Rectangle Area: {r.GetArea():F2}");

        // Circle c = new Circle("red", 9);
        // Console.WriteLine($"\nCircle Color: {c.GetColor()}");
        // Console.WriteLine($"Circle Area: {c.GetArea():F2}");
        
        shapes.Add(new Square("pink", 4.5));
        shapes.Add(new Rectangle("purple", 5, 9.5));
        shapes.Add(new Circle("yellow", 5));

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"\nShape: {shape}, Color: {color}, Area: {area:F2}\n");
        }
    }
}