using System;
using System.Collections.Generic;

public class Resume
{
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Resume for: {_personName}");
        Console.WriteLine("Work Experience:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobInfo();
        }
    }
}