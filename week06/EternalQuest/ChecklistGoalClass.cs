public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
                return _points + _bonus;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;

    public override string GetStatus() =>
        $"[{(_timesCompleted >= _targetCount ? "X" : " ")}] {_name} -- Completed {_timesCompleted}/{_targetCount} times";

    public override string GetSaveData() =>
        $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_bonus}|{_timesCompleted}";
}
