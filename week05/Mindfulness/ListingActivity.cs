// ListingActivity.cs
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new();
        Console.WriteLine($"\n--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine("Start listing items:");

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();
    }
}
