using System.Runtime.CompilerServices;

class Reflecting : Activity
{
    private string[] _prompts = new string[6]
    {"Think of a time you overcame something difficult",
     "Think of a time you were able to find hope again after something terrible",
     "Think of a time when you helped someone in need",
     "Think of a time when you were afraid to ask for help but did anyway",
     "Think of a time when you made a mistake",
     "Think of a time you believed in yourself"
    };

    private string[] _questions = new string[10]
    {"What strengths did you learn you had from that experience?",
     "What has that experience helped you to accomplish today?",
     "How did you show resilience?",
     "After going through that experience what would you like to tell your past self?",
     "How has that experience molded who you've become today?",
     "If you could summarize that experience into a motto what would it be?",
     "How did Heavenly Father help you through this experience?",
     "What habits did you form because of that experience that bless you to this day?",
     "What bad habits did you need to get rid of?",
     "Knowing what you know now, what would you have done differently?"
    };

    public string GetPrompt()
    {
        Random random = new();
        int i;
        i = random.Next(0, 5);
        return _prompts[i];
    }
    public string GetQuestion()
    {
        Random random = new();
        int i;
        i = random.Next(0, 9);
        return _questions[i] + " ";
    }
    public Reflecting(int duration, string startMessage, string endMessage) : base(duration, startMessage, endMessage)
    {
        SetInstructions(GetPrompt());
    }

    public void Display()
    {
        string previousQuestion = "";
        string newQuestion;
        DateTime future = DateTime.Now.AddSeconds(GetDuration());
        Console.WriteLine(GetStart());
        Console.WriteLine("Press the enter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();

        Console.Write("Get Ready ");
        Timer(5);
        Console.WriteLine("");
        while (DateTime.Now < future)
        {
            newQuestion = GetQuestion();
            while (newQuestion == previousQuestion)
            {
                newQuestion = GetQuestion();
            }
            previousQuestion = newQuestion;
            Console.Write(previousQuestion);
            Spinner(10);
            Console.WriteLine("");
        }
        Console.WriteLine(GetEnd());
        Thread.Sleep(3000);
    }
}