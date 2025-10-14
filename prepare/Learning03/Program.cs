using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction oneFraction = new Fraction();
        Fraction fiveFraction = new Fraction(5);
        Fraction threeFraction = new Fraction(3, 4);


        Console.WriteLine($"{oneFraction.GetFractionString()}");
        Console.WriteLine($"{oneFraction.GetDecimalValue()}");
        
        Console.WriteLine($"{fiveFraction.GetFractionString()}");
        Console.WriteLine($"{fiveFraction.GetDecimalValue()}");
        
        Console.WriteLine($"{threeFraction.GetFractionString()}");
        Console.WriteLine($"{threeFraction.GetDecimalValue()}");

        oneFraction.SetTop(1);
        oneFraction.SetBottom(3);
        Console.WriteLine($"{oneFraction.GetTop()} / {oneFraction.GetBottom()}");
        Console.WriteLine($"{oneFraction.GetDecimalValue()}");
    }
}