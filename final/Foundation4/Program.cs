using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of activities
        Running running = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycling = new Cycling("03 Nov 2022", 30, 20); // Speed in mph
        Swimming swimming = new Swimming("03 Nov 2022", 30, 10); // 10 laps

        // Add activities to a list
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Add more random activities
        activities.Add(new Running("04 Nov 2022", 40, 4.5));
        activities.Add(new Cycling("05 Nov 2022", 45, 18)); // Speed in mph
        activities.Add(new Swimming("06 Nov 2022", 25, 15)); // 15 laps

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}