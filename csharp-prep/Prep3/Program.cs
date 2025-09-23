using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 11);
        Console.WriteLine($"The number is {random}");
        string guess = "";
        int guessNum = 0;
        do
        {
            Console.WriteLine("What is your guess: ");
            guess = Console.ReadLine();
            guessNum = int.Parse(guess);

            if (guessNum < random)
            {
                Console.WriteLine($"{guessNum} is too low");
            }
            else if (guessNum > random)
            {
                Console.WriteLine($"{guessNum} is too high");
            }
        } while (guessNum != random);
        Console.WriteLine("Congrats you guessed the number");
    }
}
