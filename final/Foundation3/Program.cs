using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating events
        Event lecture = new Lecture("Lecture with Best-selling Author", "Arthur Lee", "Embark on a mind-bending journey with best-selling author Arthur Lee as he delves into the mysteries of quantum consciousness.", new DateTime(2024, 4, 5, 10, 0, 0), "123 Main St, New York, NY, USA", 50);
        Event reception = new Reception("Reception Under the Stars", "Join us for an elegant night of stargazing and celebration. RSVP now to secure your spot.", new DateTime(2024, 4, 10, 18, 0, 0), "456 Elm St, Los Angeles, CA, USA", "example@email.com");
        Event outdoorGathering = new OutdoorGathering("Picnic at Hyde Park", "Join us for a delightful outdoor gathering, where you can enjoy good food, games, and relaxation amidst London's most iconic parks.", new DateTime(2024, 4, 15, 14, 0, 0), "Hyde Park, London, UK", "Sunny");

        // Displaying event details
        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}