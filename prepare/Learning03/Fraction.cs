using System;
using System.Reflection.Metadata.Ecma335;

public class Fraction
{

    private int _top ;
    private int _bottom;


    //cconstructor with no paramenter, initlaizes Fraction to 1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    // Constructor with 1 parameter for top number, value of 1 for bottom to have a fraction of type number/1
    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }

    //constructor with two parameters
    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFraction()
    {
        string fractionWrite = $"{_top} / {_bottom}";
        return fractionWrite;
    }

    public double GetDecimal()
    {
        double decimalNotation = (double)_top / (double)_bottom;
        return decimalNotation;
    }

}
