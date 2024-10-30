public class Circle : Shape
{
    private double _radius = 0;

    public Circle (double radius, string color) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}