using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create a job instance
        Job job1 = new Job();
        job1. _jobTitle = "Software Engineer";
        job1. _company =  "Microsoft";
        job1. _startYear = 2019;
        job1. _endYear = 2022;

        //display job info

         job1.DisplayJobInfo();

        //Resume
        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Google";
        job2._startYear = 2023;
        job2._endYear = 2025;

        // Create Resume instance
        Resume myResume = new Resume();
        myResume._personName = "John Momoh";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display Resume
        myResume.DisplayResume();

    }
}