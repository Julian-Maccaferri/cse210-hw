public class Rectangle : Shape
{
    private double _shortSide = 0;
    private double _longSide = 0;

    public Rectangle (double shortSide, double longSide, string color) : base (color)
    {
        _shortSide = shortSide;
        _longSide = longSide;
    }

    public override double GetArea()
    {
        return _shortSide * _longSide;
    }
}