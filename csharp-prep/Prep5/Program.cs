using System;

class Program
{
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(ref string userName)
    {
        Console.Write("Please enter your username: ");
        userName = Console.ReadLine();
        return userName;
    }

    static void PromptUserNumber(out int num)
    {
        Console.Write("Please enter your favorite number: ");
        num = int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter your birth year: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        num = num * num;
        return num;
    }
    static void DisplayResults(string userName, int num, int year)
    {
        num = SquareNumber(num);
        year = 2025 - year;
        Console.WriteLine($"{userName}, the square of your number is {num}");
        Console.WriteLine($"{userName}, you will be {year} in 2025");
    }
    static void Main(string[] args)
    {
        string userName = "";
        int favNum;
        int birthYear;
        DisplayWelcomeMessage();
        PromptUserName(ref userName);
        PromptUserNumber(out favNum);
        PromptUserBirthYear(out birthYear);
        DisplayResults(userName, favNum, birthYear);

    }
}
