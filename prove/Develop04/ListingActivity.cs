public class ListingActivity : MindfulnessActivity
{
    private string[] listPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void DoActivity()
    {
        Console.WriteLine("Let's start listing...");
        Random random = new Random();
        string randomPrompt = listPrompts[random.Next(listPrompts.Length)];
        Console.WriteLine(randomPrompt);
        Thread.Sleep(5000);
        int itemCounter = 0;

        while (duration > 0)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCounter++;
            duration--;
        }

        Console.WriteLine($"You listed {itemCounter} items.");
        Finish();
    }
}