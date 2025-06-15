using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new();

        while (true)
        {
            Console.WriteLine($"\nScore: {manager.GetScore()}\n");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Goal\n2. List Goals\n3. Record Event\n4. Save Goals\n5. Load Goals\n6. Quit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.ListGoals(); break;
                case "3": manager.RecordEvent(); break;
                case "4":
                    Console.Write("Filename to save: ");
                    manager.SaveToFile(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("Filename to load: ");
                    manager.LoadFromFile(Console.ReadLine());
                    break;
                case "6": return;
            }
        }
    }
}

/*
EXCEEDS REQUIREMENTS:
- Added streak icons for eternal goals
- Implemented bonus leveling system: every 1000 points = Level Up
*/
