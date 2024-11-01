class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations You have earned {_points} points.");
            Console.WriteLine($"You now have {_points} points.");
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public override string GetDetailsString()
    {
        string details = base.GetDetailsString();
        
        if (_isComplete)
        {
            details += " (Completed)";
        }
        else
        {
            details += " (Incomplete)";
        }

        return details;
    }
}