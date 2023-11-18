class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override int RecordEvent()
    {
        Points += 100;
        return Points;
    }
}
