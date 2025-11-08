using System;
using System.Diagnostics;

class Program
{
    public List<string> _journalList = new();
    // public List<Entry> _journalList = new();
    static void Main(string[] args)
    {
        Entry entry = new();
        File file = new();
        Program journal = new();
        int userInput = 0;

        Console.WriteLine("Welcome to your personal journal!");

        while (userInput.GetInput() != 5)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please select one of the following options:");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (userInput)
            {
                case 1:
                    entry.Write(journal._journalList);
                    break;
                case 2:
                    entry.Display(journal._journalList);
                    break;
                case 3:
                    file.Save(journal._journalList);
                    break;
                case 4:
                    file.Load(journal._journalList);
                    break;
                case 5:
                    Console.WriteLine("Thank you for journaling today");
                    return;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }
        }
    }
}
