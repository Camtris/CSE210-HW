using System.Data.SqlTypes;
using System.Dynamic;

class Activity
{
    private int _duration;
    private string _startMessage;
    private string _endMessage;
    private string _instructions;

    public Activity(int duration, string startMessage, string endMessage)
    {
        _duration = duration;
        _startMessage = startMessage;
        _endMessage = endMessage;
    }

    public string GetStart()
    {
        return _startMessage + "\n" + _instructions;
    }

    public string GetEnd()
    {
        return _endMessage;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void SetInstructions(string newInstructions)
    {
        _instructions = newInstructions;
    }

    public void Timer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine("\b" + "...");
    }

    public void Spinner(int seconds)
    {
        List<string> spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");

        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < future)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if(i >= spinnerStrings.Count)
            {
                i = 0;
            }

        }
    }
}