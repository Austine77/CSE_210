public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            return _currentCount == _targetCount ? _points + _bonusPoints : _points;
        }
        return 0;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;
    public override string GetStatus() => IsComplete() ? "[X]" : "[ ]" + $" Completed {_currentCount}/{_targetCount}";
    public override string GetSaveString() => $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
}
