using System;

class Program
{
    static void Main(string[] args)
    {
        // Initializing objects and variables to be used
        Reference reference = new("Alma", 36, 18, 19);
        Scripture newVerse = new Scripture(reference, "Now, as my mind caught hold upon this thought, I cried within my heart:"
                                            + " O Jesus, thou Son of God, have mercy on me, who am in the gall of bitterness,"
                                            + " and am encircled about by the everlasting chains of death. And now, behold when I"
                                            + " thought this I could remember my pains no more; yea, I was harrowed up by the"
                                            + " memory of my sins no more.");
        Scripture orginialVerse = new Scripture(reference, "Now, as my mind caught hold upon this thought, I cried within my heart:"
                                            + " O Jesus, thou Son of God, have mercy on me, who am in the gall of bitterness,"
                                            + " and am encircled about by the everlasting chains of death. And now, behold when I"
                                            + " thought this I could remember my pains no more; yea, I was harrowed up by the"
                                            + " memory of my sins no more.");
        string userInput = "";


        // Displaying the user's verse with the reference and beginning the process of hiding words.
        newVerse.Display();
        while (userInput != "quit" && newVerse.GetDisplayCount() > 0)
        {
            Console.WriteLine("If you would like to continue just press enter otherwise type quit: ");
            userInput = Console.ReadLine();
            if (userInput != "quit")
            {
                newVerse.ChangeVerse();
            }
            newVerse.Display();
        }

        // After the loop has been broken the user will exit the program or be able to see how well they memorized the verse.
        if (userInput == "quit")
        {
            Console.WriteLine("Come back soon");
        }
        else
        {
            Console.WriteLine("Would you like to see how well you memorized the verse (yes/no): ");
            userInput = Console.ReadLine();
            while (userInput != "no")
            {
                if (userInput != "yes")
                {
                    Console.WriteLine("Please type a valid option (yes/no): ");
                    userInput = Console.ReadLine();
                }
                else if (userInput == "yes")
                {
                    Console.WriteLine("Write out the verse");
                    Scripture memorizedVerse = new(reference, Console.ReadLine());
                    Console.WriteLine("Original Verse");
                    orginialVerse.Display();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Memorized Verse");
                    memorizedVerse.Display();
                    Console.WriteLine("Would you like to try again (yes/no): ");
                    userInput = Console.ReadLine();
                }
            }
        }
    }
}