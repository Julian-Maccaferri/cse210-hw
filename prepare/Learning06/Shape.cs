public class Shape
{
    private string _color = "";

    public Shape(string color)
    {
        _color = color;
    }

    public void SetShapeColor(string color)
    {
        _color = color;
    }

    public string GetShapeColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return -1;
    }
}