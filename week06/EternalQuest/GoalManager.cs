using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
            _goals.Add(new SimpleGoal(name, description, points));
        else if (choice == "2")
            _goals.Add(new EternalGoal(name, description, points));
        else if (choice == "3")
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()} ({_goals[i].GetDescription()})");
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        int earned = _goals[index].RecordEvent();
        _score += earned;
        Console.WriteLine($"You earned {earned} points! Total score: {_score}");
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter outputFile = new(filename);
        outputFile.WriteLine(_score);
        foreach (Goal g in _goals)
            outputFile.WriteLine(g.GetSaveString());
    }

    public void LoadFromFile(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        foreach (string line in lines[1..])
        {
            string[] parts = line.Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
        }
    }

    public int GetScore() => _score;
}
