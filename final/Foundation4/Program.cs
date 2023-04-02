using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _listOfActivities = new List<Activity>();

        Running runningActivity = new Running("01/04/2023", 10);
        runningActivity.SetRunningDistance(4);
        _listOfActivities.Add(runningActivity);
        Cycling cyclingActivity = new Cycling("03/04/2023",20);
        cyclingActivity.SetCyclingSpeed(20);
        _listOfActivities.Add(cyclingActivity);
        Swimming swimmingActivity = new Swimming("06/04/2023",30);
        swimmingActivity.SetNumberOfLaps(5);
        _listOfActivities.Add(swimmingActivity);

        foreach (Activity activity in _listOfActivities)
        {
            Console.WriteLine(activity.GetSummary());
        }






    }
}