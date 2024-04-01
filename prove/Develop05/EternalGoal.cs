using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // No specific attributes needed for EternalGoal
    }

    public override void RecordEvent()
    {
        // Eternal goal cannot be marked complete
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|false";
    }
}