class Fox : Mammal
{
    public Fox(string name) : base(name)
    {
        _sound = "Ringa-ding-ding-ding-ringading";
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{name} sings {_sound}");
    }
}