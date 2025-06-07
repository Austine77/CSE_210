// BreathingActivity.cs
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int interval = 6;

        while (duration > 0)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(interval / 2);
            Console.Write("Breathe out... ");
            ShowCountdown(interval / 2);
            duration -= interval;
        }

        DisplayEndingMessage();
    }
}
