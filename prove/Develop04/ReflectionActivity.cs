using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> reflectionPrompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you acted on Holy Ghost.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection")
    {
    }

    public override void Run()
    {
        Console.WriteLine($"Starting {base._name} activity...");

        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.Write("Enter the duration of reflection activity in seconds: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting

        Random random = new Random();

        while (duration > 0)
        {
            string prompt = reflectionPrompts[random.Next(reflectionPrompts.Count)];
            Console.WriteLine(prompt);
            
            foreach (string question in reflectionQuestions)
            {
                Console.WriteLine(question);

                // Display spinner during pause
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(300);
                    Console.Write(". ");
                }
                Console.WriteLine();

                Thread.Sleep(3000); // Pause for 3 seconds before displaying the next question

                duration -= 3;
                if (duration <= 0)
                    break;
            }
        }

        Console.WriteLine("Reflection activity ends.");
    }
}