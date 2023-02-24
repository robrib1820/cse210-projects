using System;

public class Listing : Activity
{
    private List<string> _promptQuestions = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    private int _randomPromptNumber;
    private int _numPrompts = 0;

    public Listing() {

    }
    public Listing(string name, string description) : base(name, description) {
        
    }
    public void RunListingActivity() {
        Console.Write("> ");
        Console.ReadLine();
        _numPrompts += 1;
    }
    public int GetRandomPromptNumber() {
        Random num = new Random();
        _randomPromptNumber = num.Next(_promptQuestions.Count);
        return _randomPromptNumber;
    }
    
    public void DisplayPrompt() {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_promptQuestions[GetRandomPromptNumber()]} ---");
        PauseCountdownTimer();
    }

    public void GetNumbPrompts() {
        Console.WriteLine($"You listed {_numPrompts} items!");
    }
}