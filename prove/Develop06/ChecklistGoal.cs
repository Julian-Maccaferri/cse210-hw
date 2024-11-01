class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _amountCompleted = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted = _amountCompleted + 1;
            Console.WriteLine($"Checklist goal '{_shortName}' progress: {_amountCompleted}/{_target} times. You earned {_points} points.");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Checklist goal '{_shortName}' completed! Bonus {_bonus} points awarded.");
            }
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_amountCompleted}|{_bonus}";
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" - Progress: {_amountCompleted}/{_target}";
    }
}