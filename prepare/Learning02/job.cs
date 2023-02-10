using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    public void DisplayJob()
    {
        Console.WriteLine($"Company: {_company} / Job: ({_jobTitle}) / Years: {_startYear}-{_endYear}");
    }
}