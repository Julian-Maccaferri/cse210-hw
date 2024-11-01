using System;

public abstract class Activity
{
    public int _length;

    public Activity(int length)
    {
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();    
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{GetType().Name} ({_length} min) - Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F2} min per unit";
    }
}

