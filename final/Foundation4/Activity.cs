class Activity
{
    private DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Base class does not have a distance attribute
    }

    public virtual double GetSpeed()
    {
        return 0; // Base class does not have a speed attribute
    }

    public virtual double GetPace()
    {
        return 0; // Base class does not have a pace attribute
    }

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} ({GetType().Name} - {minutes} min)";
    }
}