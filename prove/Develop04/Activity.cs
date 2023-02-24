using System;

public class Activity
{
    //Variables
    private string _activityName;
    private int _durationSeconds;
    private string _descriptionActivity;
    protected int _prepareTime;
    protected int _beReady;
    //Constructors
    public Activity() {

    }
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
        int secondsInt = int.Parse(seconds);
        SetDurationSeconds(secondsInt);
    }
    public void DisplayEndMessage() {
        Console.WriteLine("Well done!!");
        MiniSpinner(4);
        Console.WriteLine($"You have completed another {_durationSeconds} seconds of the {_activityName}");
        MiniSpinner(4);
        Console.Clear();
    }
    public void PauseSpinner() {
        for (int i = 1; i <= 1; i++)
        { 
            MiniSpinner(4);
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
        MiniSpinner(4);
    }
    public void SetDurationSeconds(int numberOfSeconds) {
        _durationSeconds = numberOfSeconds;
    }
    public int GetDurantionSeconds() {
        return _durationSeconds;
        
        
    }
    public void MiniSpinner(int numTimes) {
        for (int i = 1; i <= numTimes; i++)
        { 
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b—");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
        }
        Console.Write("\b \b");
    }

    // public void testeFunction() {
    //     DateTime futureTime = DateTime.Now.AddSeconds(30);
    //     while (DateTime.Now < futureTime)
    //     {
    //         Listing teste = new Listing();
    //         teste.RunListingActivity();
    //     }
    //     Console.WriteLine("Task completed");
    // }
}