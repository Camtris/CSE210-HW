using Microsoft.VisualBasic;

class Listing : Activity
{
    private string[] _experiences = new string[6]
    {"How have you seen the Lord's hand in your life?",
     "What was something nice that someone did for you today?",
     "How have you felt God's love lately?",
     "Count as many blessing as you can recognize",
     "What are somethings that made you happy today?",
     "What spiritual activities have you done lately?",
    };
    private int _count;


    public string GetExperience()
    {
        Random random = new();
        int i;
        i = random.Next(0, 5);
        return _experiences[i];
    }

    public int GetCount()
    {
        return _count;
    }

    public Listing(int duration, string startMessage, string endMessage, int count) : base(duration, startMessage, endMessage)
    {
        _count = count;
        SetInstructions(GetExperience());
    }

    public void Display()
    {
        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(GetDuration());

        Console.Write($"Get Ready ");
        Timer(5);
        Console.WriteLine("");
        Console.WriteLine(GetStart());
        while (current < future)
        {
            Console.ReadLine();
            _count += 1;
            current = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} things");
        Console.WriteLine(GetEnd());
    }
}