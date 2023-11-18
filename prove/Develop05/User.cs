class User
{
    public string Username { get; private set; }
    public List<Goal> Goals { get; private set; }
    public int Score { get; private set; }

    public User(string username)
    {
        Username = username;
        Goals = new List<Goal>();
        Score = 0;
    }

    public void CreateGoal(GoalType goalType, string name, int points, int repetitions = 0, int bonusPoints = 0)
    {
        Goal goal;
        switch (goalType)
        {
            case GoalType.Simple:
                goal = new SimpleGoal(name, points);
                break;
            case GoalType.Eternal:
                goal = new EternalGoal(name, points);
                break;
            case GoalType.Checklist:
                goal = new ChecklistGoal(name, points, repetitions, bonusPoints);
                break;
            default:
                throw new ArgumentException("Invalid goal type");
        }
        Goals.Add(goal);
    }

    public string RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Goal goal = Goals[goalIndex];
            if (!goal.Completed)
            {
                int eventPoints = goal.RecordEvent();
                Score += eventPoints;
                return $"Event recorded for goal '{goal.Name}'. Earned {eventPoints} points.";
            }
            else
            {
                return $"Goal '{goal.Name}' is already completed.";
            }
        }
        else
        {
            return "Invalid goal index.";
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            string completionStatus = Goals[i].Completed ? "[X]" : "[ ]";
            if (Goals[i] is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{i + 1}. {completionStatus} {checklistGoal.Name} (Completed {checklistGoal.CurrentRepetitions}/{checklistGoal.Repetitions} times)");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {completionStatus} {Goals[i].Name}");
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score for {Username}: {Score}");
    }
}