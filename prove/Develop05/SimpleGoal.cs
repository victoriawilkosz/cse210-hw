using System;

class SimpleGoal : Goal
{
    protected bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string completeStatus = _isComplete ? "[X]" : "[ ]";
        return $"{completeStatus} {_shortName}: {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public void SetCompleteStatus(bool status)
    {
        _isComplete = status;
    }
}