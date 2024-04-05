using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating videos
        Video video1 = new Video("Video 1", "Jane Doe", 120);
        Video video2 = new Video("Video 2", "John Smith", 180);
        Video video3 = new Video("Video 3", "Mary Ann", 458);

        // Adding comments to videos
        video1.AddComment(new Comment("Jack", "Great video!"));
        video1.AddComment(new Comment("Kate", "Nice work!"));
        video1.AddComment(new Comment("Rose", "Loved it"));
        video1.AddComment(new Comment("Emma", "I really like your channel."));

        video2.AddComment(new Comment("Roy", "Very informative"));
        video2.AddComment(new Comment("Joe", "When can we expect a new video?"));
        video2.AddComment(new Comment("Taylor", "I learned so much from this"));
        video2.AddComment(new Comment("Monica", "You're a great teacher, thanks."));

        video3.AddComment(new Comment("Michael", "I didn't like it..."));
        video3.AddComment(new Comment("Jim", "Good editing skills on this video!"));
        video3.AddComment(new Comment("Eveline", "Who's also eating lunch while watching?"));
        video3.AddComment(new Comment("Natalie", "Amen! I agree!"));

        // Displaying video details
        Console.WriteLine("Video 1 Details:");
        video1.DisplayVideoDetails();

        Console.WriteLine("\nVideo 2 Details:");
        video2.DisplayVideoDetails();

        Console.WriteLine("\nVideo 3 Details:");
        video3.DisplayVideoDetails();
    }
}