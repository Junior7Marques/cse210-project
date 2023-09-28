using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Administrative Assistant";
        job1._company = "Wechsel";
        job1._startYear = 2011;
        job1._endYear = 2013;

        Job job2 = new Job();
        job2._jobTitle = "Administrative Analist";
        job2._company = "Eldorado Mall";
        job2._startYear = 2013;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._jobTitle = "Process Analist";
        job3._company = "Sephora Brasil";
        job3._startYear = 2022;
        job3._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Edilson Junior";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}