using System;

class Program
{
    static void Main(string[] args)
    {
        // Here we are defining our variables and getting input from the user about their grade
        Console.WriteLine("What is your grade percent (ex: 80%)? ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);
        string letter;
        string notification;
        string sign = "";

        // Here we are checking to see if the student is passing the class

        if (gradePercent >= 70)
        {
            notification = "Congrats! You are passing";
        }
        else
        {
            notification = "Unfortunately you are not passing. Better luck next time";
        }

        // Here we are checking to see what letter grade the student has in the class

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Here we are determing the sign the student should have attached to their grade
        if (gradePercent <= 96 && gradePercent >= 60)
        {
            if (gradePercent % 10 >= 7)
            {
                sign = "+";
            }
            else if (gradePercent % 10 <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else
        {
            sign = "";
        }


        // Next we are printing off all the information the student gave us
        Console.WriteLine($"Your grade is {letter}{sign}");
        Console.WriteLine($"{notification}");
    }
}
