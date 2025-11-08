class Visualization : Activity
{
    private string _prompt;
    private string[] _scenarios = new string[6]
    {"What can you see?",
     "What do you hear?",
     "What do you feel?",
     "What do you smell?",
     "Why is this place relaxing to you?",
     "What memories do you have associated with this place?",
    };

    public Visualization(int duration, string startMessage, string endMessage, string prompt) : base(duration, startMessage, endMessage)
    {
        _prompt = prompt;
        SetInstructions(_prompt);
    }

    public string GetScenario()
    {
        Random random = new();
        int i = random.Next(0, 5);
        return _scenarios[i];
    }

    public void Display()
    {
        string previousScenario = "";
        string newScenario;
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
            newScenario = GetScenario();
            while (newScenario == previousScenario)
            {
                newScenario = GetScenario();
            }
            previousScenario = newScenario;
            Console.Write(previousScenario);
            Spinner(10);
            Console.WriteLine("");
        }
        Console.WriteLine(GetEnd());
        Thread.Sleep(3000);
    }
}