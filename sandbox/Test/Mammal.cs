class Mammal
{
    protected string _name;
    protected string _sound = "";

    public Mammal(string name)
    {
        _name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{_name} makes no sound");
    }
}