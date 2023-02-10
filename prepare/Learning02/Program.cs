using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Analist";
        job1._company = "Atos";
        job1._startYear = "2022";
        job1._endYear = "2025";

        Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Tata";
        job2._startYear = "2021";
        job2._endYear = "2023";

        // job1.Display();
        // Console.WriteLine("-----------------------------");
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Robson Ribeiro";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }

}