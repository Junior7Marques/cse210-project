class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create activities of each type
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 20.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 20));

        // Display summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}