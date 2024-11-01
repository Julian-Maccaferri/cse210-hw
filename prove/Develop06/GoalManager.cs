using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    protected List<Goal> _goals = new List<Goal>();
    protected int _score = 0;

    public void Start()
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        DisplayMenu();
    }

    private void DisplayMenu()
    {   
        Console.WriteLine();
        Console.WriteLine("Choose an option:");
        Console.WriteLine();
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Goal Event");
        Console.WriteLine("6. Show Score");
        Console.WriteLine("7. Exit");
        Console.WriteLine();

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                ListGoals();
                break;
            case 3:
                Console.Write("Save filename: ");
                string saveFilename = Console.ReadLine();
                SaveGoals(saveFilename);
                break;
            case 4:
                Console.Write("Load filename: ");
                string loadFilename = Console.ReadLine();
                LoadGoals(loadFilename);
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                ShowScore();
                break;
            case 7:
                Console.WriteLine("Quit");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

    DisplayMenu();
    }

    private void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create? (simple/eternal/checklist)");
        string goalType = Console.ReadLine()?.ToLower();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a description for the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points awarded for this goal: ");
        int points = int.Parse(Console.ReadLine() ?? "0");

        if (goalType == "simple")
        {
            SimpleGoal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType == "eternal")
        {
            EternalGoal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType == "checklist")
        {
            Console.Write("Enter the target number of completions: ");
            int target = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter the bonus points for completing the checklist: ");
            int bonus = int.Parse(Console.ReadLine() ?? "0");

            ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type. Please try again.");
        }

        Console.WriteLine($"Goal '{name}' created successfully.");
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Goal goal = CreateGoalFromString(line);
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    private Goal CreateGoalFromString(string representation)
    {
        string[] parts = representation.Split('|');
        string goalType = parts[0];

        if (goalType == "SimpleGoal")
        {
            return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
        }
        else if (goalType == "EternalGoal")
        {
            return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
        }
        else if (goalType == "ChecklistGoal")
        {
            return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
        }

        return null;
    }

    public void ListGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
            string details = goal.GetDetailsString();

            Console.WriteLine($"{completionStatus} {details}");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal have you accomplished? (Enter the number)");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {(_goals[i].IsComplete() ? "[X]" : "[ ]")} { _goals[i].GetDetailsString()}");
        }

        int goalIndex = int.Parse(Console.ReadLine() ?? "0") - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int pointsGained = _goals[goalIndex].RecordEvent();
            Console.WriteLine($"You've gained {pointsGained} points for completing an event for the goal '{_goals[goalIndex].GetDetailsString()}'.");
            _score += pointsGained;
        }
        else
        {
            Console.WriteLine("Invalid goal selection. Please try again.");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Your current score: {_score}");
    }
}
