public abstract class MindfulnessActivity
{
    protected int duration;
    protected string name;
    protected string description;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to {name} Activity");
        Console.WriteLine(description);
        Console.Write("Enter the duration (in seconds): ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000);
        DoActivity();
    }

    public void Finish()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You have done {name} for {duration} seconds.");
        Thread.Sleep(3000);
    }

    public abstract void DoActivity();
}