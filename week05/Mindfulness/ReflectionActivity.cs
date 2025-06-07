// ReflectionActivity.cs
using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Random rand = new();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.WriteLine("Press Enter when you're ready...");
        Console.ReadLine();

        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine($"> {_questions[rand.Next(_questions.Count)]}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
