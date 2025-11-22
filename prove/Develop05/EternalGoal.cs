using System.Runtime.CompilerServices;

class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, int pts, bool done) : base(type, name, description, pts, done)
    {
    }
    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal");
        SetName(Console.ReadLine());
        Console.WriteLine("What is a short description of your goal");
        SetDescription(Console.ReadLine());
        Console.WriteLine("How many points would you like your goal to be");
        SetPts(int.Parse(Console.ReadLine()));
    }
    public override void Record()
    {
        Console.WriteLine($"Congrats you have been awarded {GetPts()}");
    }
}