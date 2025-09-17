using System;

class Program
{
    static void Main(string[] args)
    {
        // Has user input there first and last name
        Console.WriteLine("What is your first name: ");
        string first_name = Console.ReadLine();

        Console.WriteLine("What is your last name: ");
        string last_name = Console.ReadLine();

        //Displays user input
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}
