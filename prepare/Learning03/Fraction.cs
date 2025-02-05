using System;

public class Fraction
    {
    private int _top;
    private int _bottom;

    public Fraction() // Constructor that has no parameters that initializes the number to 1/1.
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)  // Constructor that has one parameter for the top and that initializes the denominator to 1.
                                      // So that if you pass in the number 5, the fraction would be initialized to 5/1.
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)  // Constructor that has two parameters, one for the top and one for the bottom.
    {
       _top = top;
       _bottom = bottom;
    }

    // getters and setters 

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    // methods to return the representations

    public string GetFractionString()
    {
        string stringFraction = $"{_top}/{_bottom}";
        return stringFraction;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top /(double)_bottom;
        return decimalValue;
    }

}