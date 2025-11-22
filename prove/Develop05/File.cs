using System.Numerics;

class File
{
    public void Save(int total, List<Goal> list)
    {
        Console.WriteLine("What file would you like to save your goals to:");
        string fileName = Console.ReadLine();
        using (StreamWriter file = new StreamWriter(fileName))
        {
            file.WriteLine(total);
            foreach (Goal goal in list)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    file.WriteLine($"{simpleGoal.GetGoalType()},{simpleGoal.GetName()},{simpleGoal.GetDescription()},{simpleGoal.GetPts()},{simpleGoal.GetDone()}");
                }
                if (goal is EternalGoal eternalGoal)
                {
                    file.WriteLine($"{eternalGoal.GetGoalType()},{eternalGoal.GetName()},{eternalGoal.GetDescription()},{eternalGoal.GetPts()},{eternalGoal.GetDone()}");
                }
                if (goal is ChecklistGoal checklist)
                {
                    file.WriteLine($"{checklist.GetGoalType()},{checklist.GetName()},{checklist.GetDescription()},{checklist.GetTick()},{checklist.GetCounter()},{checklist.GetPts()},{checklist.GetBonus()},{checklist.GetDone()}");
                }
            }
        }
    }
    public int Load(List<Goal> list)
    {
        int total;

        Console.WriteLine("What file would you like to load from ");
        string fileName = Console.ReadLine();
        using (StreamReader file = new StreamReader(fileName))
        {
            string line;
            string[] parts;
            total = int.Parse(file.ReadLine());
            while ((line = file.ReadLine()) != null)
            {
                parts = line.Split(",");
                if (parts[0] == "SimpleGoal")
                {
                    Goal goal1 = new SimpleGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    list.Add(goal1);
                }
                if (parts[0] == "EternalGoal")
                {
                    Goal goal2 = new EternalGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    list.Add(goal2);
                }
                if (parts[0] == "ChecklistGoal")
                {
                    Goal goal3 = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                    list.Add(goal3);
                }
            }
        }
        return total;
    }
}
    