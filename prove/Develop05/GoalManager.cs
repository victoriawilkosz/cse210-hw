using System;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
{
    LoadGoals();
    int choice = -1;
    while (choice != 0)
    {
        Console.WriteLine("1. Display Player Info");
        Console.WriteLine("2. List Goal Names");
        Console.WriteLine("3. List Goal Details");
        Console.WriteLine("4. Create Goal");
        Console.WriteLine("5. Mark Goals As Complete");
        Console.WriteLine("6. Save Goals");
        Console.WriteLine("7. Load Goals");
        Console.WriteLine("0. Exit");

        if (_goals.Count > 0)
        {
            Console.WriteLine("--------------------"); // Separator
            Console.WriteLine();
        }

        Console.WriteLine("--------------------"); // Line separator

        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                DisplayPlayerInfo();
                break;
            case 2:
                if (_goals.Count == 0)
                {
                    Console.WriteLine("No goals yet - create one");
                }
                else
                {
                    ListGoalNames();
                }
                break;
            case 3:
                if (_goals.Count == 0)
                {
                    Console.WriteLine("No goals yet - create one");
                }
                else
                {
                    ListGoalDetails();
                }
                break;
            case 4:
                CreateGoal();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                SaveGoals();
                break;
            case 7:
                LoadGoals();
                break;
            case 0:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice! Try again.");
                break;
        }
    }
}

   public void DisplayPlayerInfo()
{
    Console.WriteLine($"Player's current score: {_score}");

    string rank = GetRank(_score);
    if (!string.IsNullOrEmpty(rank))
    {
        Console.WriteLine($"Current rank: {rank}");
    }
}

private string GetRank(int score)
{
    if (score >= 0 && score < 100)
    {
        return "Beginner Goal-setter";
    }
    else if (score >= 100 && score < 500)
    {
        return "Efficient Achiever";
    }
    else if (score >= 500 && score < 750)
    {
        return "Persistent Achiever";
    }
    else if (score >= 750 && score < 1000)
    {
        return "Dedicated Taskmaster";
    }
    else if (score >= 1000 && score < 5000)
    {
        return "Master of Goals";
    }
    // Add more ranks as needed
    else
    {
        return "Goal-setting Legend";
    }
}

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetType().Name}: {_goals[i].GetName()}");
        }
    }

  public void ListGoalDetails()
{
    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetType().Name}: {_goals[i].GetDetailsString()}");
    }
}

    public void CreateGoal()
    {
        Console.Write("Enter goal type (Simple/Eternal/Checklist): ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = Convert.ToInt32(Console.ReadLine());

        Goal goal;
        switch (type.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                Console.Write("Enter target: ");
                int target = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter bonus: ");
                int bonus = Convert.ToInt32(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type!");
                return;
        }

        _goals.Add(goal);
    }

    public void RecordEvent()
{
    Console.WriteLine("List of goals:");
    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetType().Name}: {_goals[i].GetDetailsString()}");
    }

    Console.Write("Enter the index of the goal to mark it as complete: ");
    int index = Convert.ToInt32(Console.ReadLine());

    // Validate the index
    if (index < 1 || index > _goals.Count)
    {
        Console.WriteLine("Invalid index!");
        return;
    }

    Goal goal = _goals[index - 1];
    goal.RecordEvent();
    _score += goal.GetPoints();

    Console.WriteLine("Great job! Goal complete.");
}
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    Goal goal;
                    switch (type.ToLower())
                    {
                        case "simple":
                            bool isComplete = bool.Parse(parts[4]);
                            goal = new SimpleGoal(name, description, points);
                            ((SimpleGoal)goal).SetCompleteStatus(isComplete);
                            break;
                        case "eternal":
                            goal = new EternalGoal(name, description, points);
                            break;
                        case "checklist":
                            int amountCompleted = int.Parse(parts[4]);
                            int target = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);
                            goal = new ChecklistGoal(name, description, points, target, bonus);
                            ((ChecklistGoal)goal).SetAmountCompleted(amountCompleted);
                            break;
                        default:
                            Console.WriteLine("Invalid goal type!");
                            return;
                    }

                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}