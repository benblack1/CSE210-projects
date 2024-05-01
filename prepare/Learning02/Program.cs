using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Senior Cheif Software Engineer over Operations";
        job1._company = "Google";
        job1._endYear = 2021;
        job1._startYear = 2010;
        //job1.Display();
        
        Job job2 = new Job();
        job2._endYear = 2024;
        job2._startYear = 2021;
        job2._company = "Microsoft";
        job2._jobTitle = "Unpaid Intern";

        //job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Joe Schmoe ";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}