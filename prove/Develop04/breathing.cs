using System.Linq.Expressions;
using Microsoft.VisualBasic;

class Breathing : Activity
{
    public Breathing(int duration, string startMessage, string endMessage) : base(duration, startMessage, endMessage)
    {
        
    }
    public void Display()
    {
        int interval;
        interval = GetDuration() / 10;

        Console.Write("Get Ready ");
        Timer(5);

        while (interval > 0)
        {
            Console.Write("Breathe In ");
            Timer(5);
            Console.Write("Breathe Out ");
            Timer(5);
            Console.WriteLine("");
            interval -= 1;
        }
        Console.WriteLine(GetEnd());
        Thread.Sleep(5000);
    }
}