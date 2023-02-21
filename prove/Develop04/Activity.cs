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
    //Methods
    public void DisplayStartMessage() {
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine(_descriptionActivity);
        Console.Write("How long, in seconds, would you like for your session?");
        string seconds = Console.ReadLine();
        _durationSeconds = int.Parse(seconds);
    }
    public void DisplaEndMessage() {
        Console.WriteLine("Well done");
        Console.WriteLine($"You have completed another {_durationSeconds} seconds of the {_activityName}");
    }
    public void PauseSpinner() {
        for (int i = 0; i <= _durationSeconds; i++)
        { 
            Console.Write("—");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}