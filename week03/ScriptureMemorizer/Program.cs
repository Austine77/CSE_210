using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ✨ EXCEEDING REQUIREMENT: Scripture randomly selected from a list
        List<(Reference, string)> scriptures = new List<(Reference, string)>()
        {
            (new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            (new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy.")
        };

        Random rand = new Random();
        var (refObj, verseText) = scriptures[rand.Next(scriptures.Count)];

        Scripture scripture = new Scripture(refObj, verseText);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }
    }
}
