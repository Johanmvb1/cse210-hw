using System;

public class Resume
{
    public string _name;

    public List<job> _jobs = new List<job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"name: {_name}" );
        Console.WriteLine("Jobs");

        
        foreach (job job in _jobs)
        {
            job.DisplayJobDetails();
        }

        
    }
}   