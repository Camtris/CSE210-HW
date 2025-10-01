using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Resume myresume = new Resume();
        string userInput = "";

        Console.WriteLine("What is your name? ");
        myresume._name = Console.ReadLine();

        while (userInput != "no")
        {
            Jobs job = new Jobs();
            Console.Write("Company you have worked for: ");
            job._company = Console.ReadLine();
            Console.Write("Position: ");
            job._jobTitle = Console.ReadLine();
            Console.Write("Start Year: ");
            job._startYear = int.Parse(Console.ReadLine());
            Console.Write("End Year: ");
            job._endYear = int.Parse(Console.ReadLine());
            myresume._jobs.Add(job);

            Console.WriteLine("Would you like to add another job to your resume? ");
            userInput = Console.ReadLine();

        }
        myresume.Display();
    }
}