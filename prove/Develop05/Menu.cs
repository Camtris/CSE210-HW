class Menu
{
    private int _selector;
    private List<Goal> _goals = new List<Goal>();
    private File file = new();
    private int _total = 0;
    public void List()
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i += 1;
            string check = "";
            if (goal is SimpleGoal || goal is ChecklistGoal)
            {
                if (goal.GetDone() == true)
                {
                    check = "X";
                }

            }
            if (goal is ChecklistGoal checklist)
            {
                Console.WriteLine($"{i}. [{check}] {checklist.GetName()} ({checklist.GetDescription()})  {checklist.GetTick()}/{checklist.GetCounter()}");
            }
            else
            {
                Console.WriteLine($"{i}. [{check}] {goal.GetName()} ({goal.GetDescription()})");
            }

        }
    }
    public void Remove()
    {
        List();
        Console.WriteLine("What goal would you like to remove?");
        int userInput = int.Parse(Console.ReadLine());
        if (_goals[userInput - 1] is SimpleGoal simple)
        {
            if (simple.GetDone() == false)
            {
                Console.WriteLine("You haven't completed this goal are you sure you want to remove it (yes/no): ");
                string response = Console.ReadLine();
                if (response == "yes")
                {
                    _goals.RemoveAt(userInput - 1);
                }
            }
            else
            {
                _goals.RemoveAt(userInput - 1);
            }
        }
        else if (_goals[userInput - 1] is ChecklistGoal checklist)
        {
            if (checklist.GetDone() == false)
            {
                Console.WriteLine("You haven't completed this goal are you sure you want to remove it (yes/no): ");
                string response = Console.ReadLine();
                if (response == "yes")
                {
                    _goals.RemoveAt(userInput - 1);
                }
            }
            else
            {
                _goals.RemoveAt(userInput - 1);
            }
        }
        else
        {
            _goals.RemoveAt(userInput - 1);
        }
    }

    public void Display()
    {
        bool state = true;
        Console.Clear();

        while (state != false)
        {
            Console.WriteLine($"Total Pts: {_total}");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Remove Goal");
            Console.WriteLine("7. Quit");
            Console.WriteLine("Please select an option");
            _selector = int.Parse(Console.ReadLine());

            switch (_selector)
            {
                case 1:
                    Console.Clear();
                    int userInput = 0;
                    while (userInput > 3 || userInput < 1)
                    {
                        Console.WriteLine("The types of Goals are:");
                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. CheckList Goal");
                        userInput = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    if (userInput == 1)
                    {
                        Goal goal = new SimpleGoal("SimpleGoal", " ", "", 0, false);
                        goal.CreateGoal();
                        _goals.Add(goal);
                    }
                    if (userInput == 2)
                    {
                        Goal goal2 = new EternalGoal("EternalGoal", "", "", 0, false);
                        goal2.CreateGoal();
                        _goals.Add(goal2);
                    }
                    if (userInput == 3)
                    {
                        Goal goal3 = new ChecklistGoal("ChecklistGoal", "", "", 0, 0, 0, 0, false);
                        goal3.CreateGoal();
                        _goals.Add(goal3);
                    }
                    Console.Clear();
                    state = true;
                    break;
                case 2:
                    Console.Clear();
                    List();
                    Console.WriteLine("Press enter when you want to go back to the menu: ");
                    Console.ReadLine();
                    Console.Clear();
                    state = true;
                    break;
                case 3:
                    Console.Clear();
                    file.Save(_total, _goals);
                    Console.WriteLine("Successfully saved");
                    Thread.Sleep(2500);
                    Console.Clear();
                    state = true;
                    break;
                case 4:
                    Console.Clear();
                    _total = file.Load(_goals);
                    Console.Clear();
                    state = true;
                    break;
                case 5:
                    Console.Clear();
                    List();
                    Console.WriteLine("What goal would you like to check off: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    Goal currentgoal = _goals[index];
                    if (currentgoal.GetDone() == true)
                    {
                        Console.WriteLine("You have already completed this goal");
                        Thread.Sleep(2500);
                    }
                    else
                    {
                        currentgoal.Record();
                        _total += currentgoal.GetPts();
                        if (currentgoal is ChecklistGoal checklist && checklist.GetDone() == true)
                        {
                            _total += checklist.GetBonus();
                        }
                        Thread.Sleep(2500);
                    }
                    Console.Clear();
                    state = true;
                    break;
                case 6:
                    Console.Clear();
                    Remove();
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    state = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option");
                    Thread.Sleep(2500);
                    Console.Clear();
                    state = true;
                    break;
            }
        }
    }
}