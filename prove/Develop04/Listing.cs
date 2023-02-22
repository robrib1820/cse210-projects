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
    private string _randomPrompt;
    private int _randomPromptNumber;
    private int _numItems;

    public Listing(string name, string description) : base(name, description) {

    }
    public void RunListingActivity() {
        BeReady();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_promptQuestions[GetRandomPromptNumber()]} ---");
        PauseCountdownTimer();
        ResponseList();

    }
    public int GetRandomPromptNumber() {
        Random num = new Random();
        _randomPromptNumber = num.Next(_promptQuestions.Count);
        return _randomPromptNumber;
    }
    public string GetRandomPrompt() {
        return _randomPrompt;
    }
    public int GetNumListedItems() {
        return _numItems;
    }
    public void ResponseList() {
        _numItems = 0;
        Boolean ListingThings = true;
        while (ListingThings == true)
        {
            Console.Write("> ");
            Console.ReadLine();
            _numItems += 1;

            if (_numItems == 4)
            {
                ListingThings = false;
            }
        } 
        Console.WriteLine($"You listed {_numItems} items!");
    }
}