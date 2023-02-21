using System;

public class Activity
{
    //Variables
    private string _activityName;
    private int _durationSeconds;
    private string _descriptionActivity;
    private string _completedSeconds;
    protected int _prepareTime;
    protected int _beReady;
    //Constructors
    public Activity(string name, string description) {
        _activityName = name;
        _descriptionActivity = description;
        _beReady = 4;
    }
    //Methods
    public void DisplayStartMessage() {
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine(_descriptionActivity);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?");
        string seconds = Console.ReadLine();
        _durationSeconds = int.Parse(seconds);
    }
    public void DisplayEndMessage() {
        Console.WriteLine("Well done");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_durationSeconds} seconds of the {_activityName}");
    }
    public void PauseSpinner() {
        for (int i = 1; i <= _durationSeconds; i++)
        { 
            Console.Write("\b—");
            Thread.Sleep(166);
            Console.Write("\b|");
            Thread.Sleep(166);
            Console.Write("\b/");
            Thread.Sleep(166);
            Console.Write("\b—");
            Thread.Sleep(166);
            Console.Write("\b\\");
            Thread.Sleep(166);
            Console.Write("\b|");
            Thread.Sleep(166);
            Console.Write("\b/");
        }
        Console.Clear();
    }

    public void PauseCountdownTimer() {
        for (int i = 0; i < 1; i++)
        {
            Console.Write("\bYou may begin in: 5");
            Thread.Sleep(1000);
            Console.Write("\b4");
            Thread.Sleep(1000);
            Console.Write("\b3");
            Thread.Sleep(1000);
            Console.Write("\b2");
            Thread.Sleep(1000);
            Console.Write("\b1");
            Thread.Sleep(1000);
        }
        Console.Clear();
    }
    public void BeReady() {
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        for (int i = 1; i <= _beReady; i++)
        { 
            Console.Write("\b—");
            Thread.Sleep(166);
            Console.Write("\b|");
            Thread.Sleep(166);
            Console.Write("\b/");
            Thread.Sleep(166);
            Console.Write("\b—");
            Thread.Sleep(166);
            Console.Write("\b\\");
            Thread.Sleep(166);
            Console.Write("\b|");
            Thread.Sleep(166);
            Console.Write("\b/");
        }
    }
    public void SessionTime() {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5000);

        Thread.Sleep(6000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
        }
        else 
        {
            Console.WriteLine("yeah!!");
        }
    }

}