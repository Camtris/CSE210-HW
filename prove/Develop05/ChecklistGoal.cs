    class ChecklistGoal : Goal
    {
        private int _counter;
        private int _bonusPts;
        private int _tick;
        public ChecklistGoal(string type, string name, string description, int tick, int counter, int pts, int bonusPts, bool done) : base(type, name, description, pts, done)
        {
            _tick = tick;
            _counter = counter;
            _bonusPts = bonusPts;
        }
        public int GetCounter()
        {
            return _counter;
        }
        public void SetCounter(int counter)
        {
             _counter = counter;
        }
        public int GetBonus()
        {
            return _bonusPts;
        }
        public void SetBonus(int bonus)
        {
            _bonusPts = bonus;
        }
        public int GetTick()
        {
            return _tick;
        }
        public override void CreateGoal()
        {
            Console.WriteLine("What is the name of your goal");
            SetName(Console.ReadLine());
            Console.WriteLine("What is a short description of your goal");
            SetDescription(Console.ReadLine());
            Console.WriteLine("How many points would you like your goal to be");
            SetPts(int.Parse(Console.ReadLine()));
            Console.WriteLine("How many times does this goal need to be completed for a bonus");
            SetCounter(int.Parse(Console.ReadLine()));
            Console.WriteLine("How many points would you like your bonus to be");
            SetBonus(int.Parse(Console.ReadLine()));
        }
        public override void Record()
        {
            _tick += 1;
            if (_tick < _counter)
            {
                Console.WriteLine($"Congrats you have been awarded {GetPts()}");
            }
            if (_tick == _counter)
            {
                bool done = true;
                SetDone(done);
                Console.WriteLine($"Congrats you have been awarded {GetPts() + GetBonus()}");
            }
        }
    }