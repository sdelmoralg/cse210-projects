using System;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;
    public Square(string color, double side) : base(color) // costructor
    {
        _side = side;
    }

    public override double GetArea() // method overriding
    {
        return _side * _side;
    }
}