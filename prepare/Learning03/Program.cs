using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);    

        Console.WriteLine(fraction1.GetTopNumber());
        Console.WriteLine(fraction1.GetBottomNumber());

        Console.WriteLine(fraction2.GetTopNumber());
        Console.WriteLine(fraction2.GetBottomNumber());

        Console.WriteLine(fraction3.GetTopNumber());
        Console.WriteLine(fraction3.GetBottomNumber());

        Fraction fraction4 = new Fraction();
        fraction4.SetTopNumber(6);
        Console.WriteLine(fraction4.GetTopNumber());

        Fraction fraction5 = new Fraction();
        fraction5.SetTopNumber(3);
        fraction5.SetBottomNumber(4);
        Console.WriteLine($"{fraction5.GetTopNumber()}/{fraction5.GetBottomNumber()}");
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());
    }
}