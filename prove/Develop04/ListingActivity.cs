using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> listingPrompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing")
    {
    }

    public override void Run()
    {
        Console.WriteLine($"Starting {base._name} activity...");

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.Write("Enter the duration of listing activity in seconds: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Count)];

        Console.WriteLine(prompt);
        Console.WriteLine("You have a few seconds to think about the prompt before listing items.");

        Thread.Sleep(5000); // Pause for 5 seconds before starting to list items

        Console.WriteLine("Begin listing items:");

        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("- ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items:");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Listing activity ends.");
    }
}