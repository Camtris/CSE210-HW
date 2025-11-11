namespace Test;

using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Mammal myPet = new("Ryan");
        myPet.MakeSound();
        Mammal newPet = new Fox("Ylvis");
        newPet.MakeSound();

    }
}
