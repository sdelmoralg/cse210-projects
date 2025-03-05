using System;

public class Rectangle : Shape
{
    private double _height;
    private double _width;

    public Rectangle(string color, double height, double width) : base (color) // constructor
    {
        _height = height;
        _width = width;
    }

    public override double GetArea() // method overriding
    {
        return _height * _width;
    }
}