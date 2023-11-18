class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        Completed = false;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }
}