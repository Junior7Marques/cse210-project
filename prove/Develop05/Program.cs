class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string username = Console.ReadLine();
        User user = new User(username);

        user.CreateGoal(GoalType.Simple, "Run a Marathon", 1000);
        user.CreateGoal(GoalType.Eternal, "Read Scriptures", 100);
        user.CreateGoal(GoalType.Checklist, "Attend Temple", 50, 10, 500);


        Console.WriteLine($"Initial Goals for {user.Username}:");
        user.DisplayGoals();


        Console.WriteLine("\nRecording Events for Goals:");
        Console.WriteLine(user.RecordEvent(0));
        Console.WriteLine(user.RecordEvent(1));
        Console.WriteLine(user.RecordEvent(2));


        Console.WriteLine("\nUpdated Goals and Score:");
        user.DisplayGoals();
        user.DisplayScore();


        Console.WriteLine("\nRecording More Events:");
        Console.WriteLine(user.RecordEvent(2));
        Console.WriteLine(user.RecordEvent(2));


        // Step 7: Display user's Progress
        Console.WriteLine("\nUpdated Goals and Score:");
        user.DisplayGoals();
        user.DisplayScore();
    }
}

enum GoalType
{
    Simple,
    Eternal,
    Checklist
}
