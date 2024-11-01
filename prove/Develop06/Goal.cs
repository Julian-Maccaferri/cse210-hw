using System;

abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName =  shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }
}