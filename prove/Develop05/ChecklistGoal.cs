class ChecklistGoal : Goal
{
    public int Repetitions { get; set; }
    public int CurrentRepetitions { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int repetitions, int bonusPoints) : base(name, points)
    {
        Repetitions = repetitions;
        CurrentRepetitions = 0;
        BonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        CurrentRepetitions++;
        if (CurrentRepetitions == Repetitions)
        {
            Completed = true;
            return Points + BonusPoints;
        }
        else
        {
            return Points;
        }
    }
}