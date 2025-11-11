using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new CirclePrep("blue", 1.0));
        shapes.Add(new Rectangle("red", 2, 2));
        shapes.Add(new Square("yellow", 3));

        foreach(Shape s in shapes)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine("------------------------------");
        }
    }
}