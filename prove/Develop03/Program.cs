using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
{
    List<Scripture> allScriptures = GetAllScriptures();
    
    while (allScriptures.Count > 0)
    {
        // Randomly select a scripture
        Random random = new Random();
        int index = random.Next(0, allScriptures.Count);
        Scripture selectedScripture = allScriptures[index];
        
        // Run the program
        RunScriptureProgram(selectedScripture);
        Console.Clear();
        
        // Remove the selected scripture from the list
        allScriptures.RemoveAt(index);
    }
}

    // Store the scriptures
    static List<Scripture> GetAllScriptures()
    {
        List<Scripture> allScriptures = new List<Scripture>();

        allScriptures.Add(new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."));
        allScriptures.Add(new Scripture(new Reference("Alma", 36, 3), "Whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day."));
        allScriptures.Add(new Scripture(new Reference("Alma", 7, 11), "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people."));
        allScriptures.Add(new Scripture(new Reference("Moroni", 10, 32), "Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God."));
        allScriptures.Add(new Scripture(new Reference("Mosiah", 4, 9), "Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend."));
        allScriptures.Add(new Scripture(new Reference("2 Nephi", 9, 51), "Wherefore, do not spend money for that which is of no worth, nor your labor for that which cannot satisfy."));
        allScriptures.Add(new Scripture(new Reference("Jeremiah", 17, 7), "Blessed is the man that trusteth in the Lord, and whose hope the Lord is."));
        allScriptures.Add(new Scripture(new Reference("Matthew", 11, 28, 30), "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light."));
        allScriptures.Add(new Scripture(new Reference("John", 14, 27), "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid."));

        return allScriptures;
    }

    static void RunScriptureProgram(Scripture scripture)
    {
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            Console.Clear();
            scripture.HideRandomWords(2); // Adjust the number of words to hide
        }
    }
}