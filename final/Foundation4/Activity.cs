using System;

public class Activity
{
    protected string date;
    protected int lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // To be implemented by derived classes
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}