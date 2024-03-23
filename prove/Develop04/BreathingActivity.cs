using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing")
    {
    }

    public override void Run()
    {
        Console.WriteLine($"Starting {base._name} activity...");

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Console.Write("Enter the number of times you want to repeat the breathing cycle: ");
        int repetitions = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting

        for (int i = 0; i < repetitions; i++)
        {
            Console.WriteLine("Breathe in...");

            // Simulate text growing out quickly during inhalation
            for (int j = 0; j < 10; j++)
            {
                Console.Write("Breathe in" + new string(' ', j));
                Thread.Sleep(200); // Speed of animation
                Console.CursorLeft = 0;
            }

            Thread.Sleep(1000); // Pause for 1 second at full inhalation

            Console.WriteLine("Breathe out...");

            // Simulate text shrinking slowly during exhalation
            for (int j = 10; j >= 0; j--)
            {
                Console.Write("Breathe out" + new string(' ', j));
                Thread.Sleep(400); // Adjust speed of animation
                Console.CursorLeft = 0;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Activity ends.");
    }
}