using System;

public class Activity
{
    //Variables
    private string _activityName;
    private int _durationSeconds;
    private string _descriptionActivity;
    private string _completedSeconds;
    protected int _prepareTime;
    protected string _beReady;
    //Constructors
    public Activity(string name, string description) {
        _activityName = name;
        _descriptionActivity = description;
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
}