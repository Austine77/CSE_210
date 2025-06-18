// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store all types of activities
        List<Activity> activities = new List<Activity>();

        // Add one Running activity (Date, Minutes, Distance in km)
        Running run = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        activities.Add(run);

        // Add one Cycling activity (Date, Minutes, Speed in kph)
        Cycling bike = new Cycling(new DateTime(2022, 11, 3), 45, 15.0);
        activities.Add(bike);

        // Add one Swimming activity (Date, Minutes, Laps)
        Swimming swim = new Swimming(new DateTime(2022, 11, 3), 40, 30);
        activities.Add(swim);

        // Loop through the list and print each activity's summary
        Console.WriteLine("Exercise Tracking Summary:\n");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
