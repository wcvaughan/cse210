using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(5, 7);
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f2.GetTop());
        Console.WriteLine(f3.GetBottom());
        f3.SetTop(7);
        f3.SetBottom(5);
        Console.WriteLine(f3.GetTop());
        Console.WriteLine(f3.GetBottom());
        Console.WriteLine(f3.GetFractionString(3, 4));
        Console.WriteLine(f3.GetDecimalValue(1, 3));
    }
}