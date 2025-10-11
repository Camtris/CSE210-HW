class Entry
{
    public string[] _promptList = new string[10]
    {
        "What was the best part of your day?",
        "What was something difficult you overcame?",
        "What was something you learned today?",
        "How did you see God's hand in your life today?",
        "Who impacted your life for the better today?",
        "How did you make an impact in someone's life today",
        "What fictional character could you relate to the most based on how you felt and acted today?",
        "How were you 1% better today? If not how do you want to be 1% better tomorrow?",
        "What made you smile?",
        "If you could change one thing about today what would it be? Why?",
    };
    public string[] _challengeList = new string[5]
    {
        "It's national ____ day (Ex: national ice cream day)",
        "What celebrity's birthday is it today?",
        "What movie came out on this day?",
        "What college sports team is ranked #1?",
        "What is the #1 Billboard 100 song?"
    };
    public string _date;
    public string _journalEntry;
    public string _prompt;
    public string _userResponse;
    public List<string> Write(List<string> list)
    {
        Random random = new();
        DateTime current = DateTime.Now;
        string input;
        _date = current.ToShortDateString();

        Console.WriteLine("Would you like a challenge prompt? ");
        input = Console.ReadLine();

        if (input == "yes")
        {
            _prompt = _challengeList[random.Next(0, 4)];
        }
        else
        {
            _prompt = _promptList[random.Next(0, 9)];
        }

        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine($"{_date}: {_prompt}");
        _userResponse = Console.ReadLine();
        _journalEntry = _date + ": " + _prompt + "\n" + _userResponse + "\n";
        list.Add(_journalEntry);
        return list;
    }

    public void Display(List<string> list)
    {
        Console.WriteLine("------------------------------------------");
        foreach (string journal in list)
        {
            Console.WriteLine($"{journal}");
        }
        Console.WriteLine("------------------------------------------");
    }
}