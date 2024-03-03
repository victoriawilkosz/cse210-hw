using System;

class Program
{
    static void Main(string[] args)
 {
    //  Console.Write("What is the magic number? ");
    //  int magicNumber = int.Parse(Console.ReadLine());
    
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber);

        Console.ReadLine();
    }
}