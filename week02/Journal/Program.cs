using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}

class Journal
{
    private List<Entry> entries = new List<Entry>();
    private string[] prompts = new string[]
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a moment when you felt peace.",
        "What is one thing you learned today?",
        "Who made your day better today and how?"
    };

    public Journal()
    {
        // Preloaded entries (5 total)
        entries.Add(new Entry("What was the best part of your day?",
            "The best part of my day was when I finished my programming assignment. I’ve been working on it for a few days now, and finally seeing it run successfully gave me a real sense of accomplishment. It made me feel confident in my ability to grow as a software developer."));

        entries.Add(new Entry("What are you grateful for today?",
            "Today, I’m grateful for having access to a computer and the internet. It’s easy to take those things for granted, but without them, I wouldn’t be able to study or work on my assignments. I’m also thankful for the support I’ve received from friends and mentors who encourage me to keep pushing forward."));

        entries.Add(new Entry("Describe a moment when you felt peace.",
            "I felt peace this evening when I took a short break and stepped outside. The breeze was cool, and everything felt calm and quiet. Even with everything going on in life, that moment reminded me that I can still find peace if I slow down and breathe."));

        entries.Add(new Entry("What is one thing you learned today?",
            "Today I learned how to use the StreamWriter class in C# to save text to a file. This was really helpful because it means I can now save data like journal entries to disk, which is something I’ll need in many future programs."));

        entries.Add(new Entry("Who made your day better today and how?",
            "My younger sister made my day better today. She surprised me with a snack while I was studying and gave me a big smile. Her small act of kindness reminded me that love and support can come in the simplest forms."));
    }

    public void AddEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry added successfully.");
    }

    public void Display()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            Console.WriteLine("\n=== My Journal ===");
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine("-----");
            }
        }
        Console.WriteLine("Journal saved successfully to " + filename);
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 4)
            {
                string date = lines[i];
                string prompt = lines[i + 1];
                string response = lines[i + 2];
                entries.Add(new Entry(prompt, response) { Date = date });
            }
            Console.WriteLine("Journal loaded successfully from " + filename);
        }
        else
        {
            Console.WriteLine("File not found. Please check the filename.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("\n=== Journal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice (1-5): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    Console.Write("Enter filename to save to (e.g., journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load from (e.g., journal.txt): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    Console.WriteLine("Goodbye! Have a great day.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}
