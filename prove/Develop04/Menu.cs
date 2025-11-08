class Menu
{
    private int _selector;

    public void SetSelector(int selector)
    {
        _selector = selector;
    }
    public int GetSelector()
    {
        return _selector;
    }
    public void Display()
    {
        int duration;
        bool keep = true;

        while (keep != false)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Visualization Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please select an option: ");
            _selector = int.Parse(Console.ReadLine());

            switch (_selector)
            {
                case 1:
                    Breathing breath = new(0, "", "Congrats we hope you feel refreshed!");
                    Console.Clear();
                    Console.WriteLine("Welcome to the Breathing Activity");
                    Console.WriteLine("This activity will help you relax by focusing on your breathing." +
                    " You will breathe in for 5 seconds and breathe out for 5 seconds.");
                    Console.WriteLine("How long would you like to do this activity for (Please use intervals of 10)? ");
                    duration = int.Parse(Console.ReadLine());
                    Console.Clear();
                    breath.SetDuration(duration);
                    breath.Display();
                    Console.Clear();
                    keep = true;
                    break;
                case 2:
                    Reflecting reflect = new(0, "Consider the following prompt:", "Thanks for reflecting on that prompt");
                    Console.Clear();
                    Console.WriteLine("Welcome to the Reflecting Activity");
                    Console.WriteLine("This activity will help you reflect on times when you showed strength"
                    + " and resilience during some of life's trials. This will help you to recognize how you"
                    + " can continue to overcome hard things that come your way.");
                    Console.WriteLine("How long would you like to do this activity for? ");
                    duration = int.Parse(Console.ReadLine());
                    Console.Clear();
                    reflect.SetDuration(duration);
                    reflect.Display();
                    Console.Clear();
                    keep = true;
                    break;
                case 3:
                    Listing list = new(0, "List as many responses to the following prompt as you can", "Good Job!", 0);
                    Console.Clear();
                    Console.WriteLine("Welcome to the listing activity");
                    Console.WriteLine("In this activity you will reflect on the good things in life" +
                    " by listing as many things as you can that are related to the prompt");
                    Console.WriteLine("How long would you like to do this activity for? ");
                    duration = int.Parse(Console.ReadLine());
                    Console.Clear();
                    list.SetDuration(duration);
                    list.Display();
                    Thread.Sleep(3000);
                    Console.Clear();
                    keep = true;
                    break;
                case 4:
                    Visualization visual = new(0, "Consider the following prompt:", "Thanks for taking the time to visualize", "Imagine your happy place");
                    Console.Clear();
                    Console.WriteLine("Welcome to the Visualizing Activity");
                    Console.WriteLine("This activity will help you to visualize a scenario and take your mind off of"
                    + " everything weighing you down");
                    Console.WriteLine("How long would you like to do this activity for? ");
                    duration = int.Parse(Console.ReadLine());
                    Console.Clear();
                    visual.SetDuration(duration);
                    visual.Display();
                    Thread.Sleep(3000);
                    Console.Clear();
                    keep = true;
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Thanks for being mindful today");
                    keep = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select a valid option");
                    Thread.Sleep(2000);
                    Console.Clear();
                    keep = true;
                    break;
            }
        }
    }
}