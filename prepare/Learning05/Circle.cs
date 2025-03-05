using System;

public class Circle : Shape
{
    private double _radious;
    
    public Circle (string color, double radious) : base (color) // constructor
    {
        _radious = radious;
    }

    public override double GetArea() // method overriding
    {
        return Math.PI * _radious * _radious;
    }
}