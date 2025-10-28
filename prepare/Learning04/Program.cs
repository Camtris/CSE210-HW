using System;

class Program
{
    static void Main(string[] args)
    {
        Math math1 = new("Chance Ochsenbein", "Math 316", "1.3.6", "1-10");
        Writing write1 = new("Chance Ochsenbein", "English 101", "How To Write a Sentence");
        Console.WriteLine($"{math1.GetSummary()}\n{math1.GetHomeworkList()}\n");
        Console.WriteLine($"{write1.GetSummary()}\n{write1.GetWritingInformation()}");
    }
}