using System;

class Program
{
    static PromptGenerator promptGenerator = new PromptGenerator(); // Instantiate the PromptGenerator

    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(myJournal);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter file name to save: ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file.\n");
                    break;

                case "4":
                    Console.Write("Enter file name to load: ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file.\n");
                    break;

                case "5":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option (1-5).\n");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal)
    {
        Console.Write("Enter your mood: ");
        string mood = Console.ReadLine();
        Console.Write("Enter your location: ");
        string location = Console.ReadLine();

        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string entryText = Console.ReadLine();
        Entry newEntry = new Entry(DateTime.Now.ToString(), prompt, entryText, mood, location);
        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added!\n");
    }
}