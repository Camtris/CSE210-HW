class CirclePrep : Shape
{
    private double _radius;

    public CirclePrep(string color, double r) : base(color)
    {
        _radius = r;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}