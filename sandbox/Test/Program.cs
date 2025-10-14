namespace Test;

using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Bin twentyBin = new Bin("Twenty Dollar Bill", 20, 3);
        Bin tenBin = new Bin("Twenty Dollar Bill", 20, 3);

        Console.WriteLine(twentyBin.GetDenomination());

    }
}
