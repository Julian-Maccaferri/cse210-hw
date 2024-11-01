public class Cycling : Activity
{
    private double _speed;

    public Cycling(int length, double speed) : base(length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * _length;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}

