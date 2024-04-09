using System;

public class Cycling : Activity
{
    private double speed;

    public Cycling(string date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * lengthInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{date} Cycling ({lengthInMinutes} min): Distance {GetDistance():F1} miles, Speed {speed} mph, Pace: {GetPace():F2} min per mile";
    }
}