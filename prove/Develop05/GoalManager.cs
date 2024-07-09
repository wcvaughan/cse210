using System.Text.Json;
public class GoalManager
{
    private List<Goal> _goals;
    public int Score { get; private set; }

    public GoalManager(int score)
    {
        _goals = new List<Goal>();
        Score = score;
    }
    
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoalDetails();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {Score}");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            Goal newGoal = null;
            switch (choice)
            {
                case 1:
                    newGoal = new SimpleGoal(name, description, points);
                    break;
                case 2:
                    newGoal = new EternalGoal(name, description, points);
                    break;
                case 3:
                    Console.Write("What is the target for the checklist goal? ");
                    if (int.TryParse(Console.ReadLine(), out int target))
                    {
                        Console.Write("What is the bonus for completing the checklist goal? ");
                        if (int.TryParse(Console.ReadLine(), out int bonus))
                        {
                            newGoal = new ChecklistGoal(name, description, points, target, bonus);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for bonus.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for target.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid goal type selected.");
                    break;
            }

            if (newGoal != null)
            {
                _goals.Add(newGoal);
                Console.WriteLine("Goal created successfully.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        DisplayPlayerInfo();
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete?");
        ListGoalNames();
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= _goals.Count)
        {
            var goal = _goals[choice - 1];
            goal.RecordEvent();

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                Score += int.Parse(goal.Points) + checklistGoal.Bonus;
            }
            else if (goal is SimpleGoal simpleGoal && simpleGoal.IsComplete())
            {
                Score += int.Parse(goal.Points);
            }
            else if (goal is EternalGoal)
            {
                Score += int.Parse(goal.Points);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        DisplayPlayerInfo();
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the name for your save?");
        string userSaveFile = Console.ReadLine();
        string jsonString = JsonSerializer.Serialize();
        File.WriteAllText(userSaveFile, jsonString);
        Console.WriteLine($"File saved as {userSaveFile}.");

    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file you want to load?");
        string userLoadFile = Console.ReadLine(); 
        if (File.Exists(userLoadFile))
        {
            string jsonString = File.ReadAllText(userLoadFile);
            var readVariable = JsonSerializer.Deserialize</*DATA MODEL*/>(jsonString);
        }
    }
}