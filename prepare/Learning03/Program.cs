using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFraction());
        Console.WriteLine(fraction.GetDecimal());

        Fraction fraction1= new Fraction(5);
        Console.WriteLine(fraction1.GetFraction());
        Console.WriteLine(fraction1.GetDecimal());

        Fraction fraction2= new Fraction(10, 5);
        Console.WriteLine(fraction2.GetFraction());
        Console.WriteLine(fraction2.GetDecimal());

        Fraction fraction3= new Fraction(2, 8);
        Console.WriteLine(fraction3.GetFraction());
        Console.WriteLine(fraction3.GetDecimal());

    }
}