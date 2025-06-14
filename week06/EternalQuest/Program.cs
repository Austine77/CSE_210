class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Select goal type:\n1. Simple\n2. Eternal\n3. Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();
                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                    manager.AddGoal(new SimpleGoal(name, desc, points));
                else if (type == "2")
                    manager.AddGoal(new EternalGoal(name, desc, points));
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == "2")
            {
                manager.ShowGoals();
            }
            else if (choice == "3")
            {
                manager.ShowGoals();
                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(index);
            }
            else if (choice == "4")
            {
                manager.ShowScore();
            }
            else if (choice == "5")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();
                manager.SaveToFile(filename);
            }
            else if (choice == "6")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();
                manager.LoadFromFile(filename);
            }
            else if (choice == "7")
            {
                break;
            }
        }
    }
}
