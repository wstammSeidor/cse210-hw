using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Seidor Analytics";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Globant";
        job2._jobTitle = "Tech Lead";
        job2._startYear = 2015;
        job2._endYear = 2022;

        Resume resume = new Resume();
        resume._name = "Juan Perez";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}