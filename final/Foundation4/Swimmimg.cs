using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // Calculate distance in miles
        double lapDistanceMiles = 50.0 / 1000 * 0.62; // Convert lap distance from meters to miles
        return laps * lapDistanceMiles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / lengthInMinutes) * 60; // miles per hour
    }

    public override double GetPace()
    {
        return lengthInMinutes / GetDistance(); // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{date} Swimming ({lengthInMinutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}