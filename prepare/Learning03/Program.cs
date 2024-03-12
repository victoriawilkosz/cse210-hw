using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Fraction using different constructors
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {f1.GetDecimalValue()}");

        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Fraction: {f2.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {f2.GetDecimalValue()}");

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction: {f3.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {f3.GetDecimalValue()}");

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction: {f4.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {f4.GetDecimalValue()}");
    }
}