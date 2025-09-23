using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string words = "hello world!";
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string capitalized = textInfo.ToTitleCase(words);
        Console.WriteLine(capitalized);
    }
}