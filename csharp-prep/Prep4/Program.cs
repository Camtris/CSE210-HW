using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 1;
        string numString = "";
        int total = 0;
        int greatestNum = 0;
        int i = 0;
        Console.WriteLine("Write a list of numbers and type 0 when you are finished");

        while (num != 0)
        {
            Console.Write("Enter Number: ");
            numString = Console.ReadLine();
            num = int.Parse(numString);
            if (num != 0)
            {
                total += num;
                i += 1;
                if (greatestNum < num)
                {
                    greatestNum = num;
                }

                numbers.Add(num);
            }
        }
        float average = (float)total / (float)i;
        Console.WriteLine($"The total is {total}");
        Console.WriteLine($"The biggest number is {greatestNum}");
        Console.WriteLine($"The average is {average}");
    }
}
