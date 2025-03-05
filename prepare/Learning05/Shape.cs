using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

public class Shape
{
    private string _color;

    public string GetColor() // getter
    {
        return _color;
    }

    public void SetColor(string color) // setter
    {
        _color = color;
    }

    public Shape(string color) // constructor
    {
        _color = color;
    }

    public virtual double GetArea() // "virtual" allows to override in the child classes
    {
        return 0;
    }
}