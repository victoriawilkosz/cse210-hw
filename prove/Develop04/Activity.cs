using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected int _duration;

    public Activity(string name)
    {
        _name = name;
    }

    public virtual void Run()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine($"Description: {GetDescription()}");
        SetDuration();
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine("Activity begins now...");
        Thread.Sleep(1000); // Pause for 1 second
        Console.WriteLine("Activity ends...");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected virtual string GetDescription()
    {
        return "";
    }

    protected virtual void SetDuration()
    {
        Console.Write("Enter duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
    }
}