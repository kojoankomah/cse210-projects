using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Manager";
        job1._company = "Apple";
        job1._endYear = 2028;
        job1._startYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2025;
        job2._endYear = 2027;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resumes resume1 = new Resumes();
        resume1._name = "Patrick Ankomah";

        resume1.jobs.Add(job1);
        resume1.jobs.Add(job2);
        
        resume1.DisplayResume();

    }
}