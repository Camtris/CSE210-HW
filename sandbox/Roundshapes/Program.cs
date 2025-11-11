using System.Runtime.InteropServices;

namespace Roundshapes;

class Program
{
    static void Main(string[] args)
    {
        List<Roundshape> myShapes = new List<Roundshape>();
        myShapes.Add(new Circle(1));
        myShapes.Add(new Cylinder(1, 2));

        foreach(Roundshape r in myShapes)
        {
            Console.WriteLine(r.Area());
        }
    }
}
