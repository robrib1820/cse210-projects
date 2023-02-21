using System;

public class Listing : Activity
{
    private List<string> _promptQuestions = new List<string>();
    private string _randomPrompt;
    private int _numItems;

    public Listing(string name, string description) : base(name, description) {

    }
    public void RunListingActivity() {

    }
    public string GetRandomPrompt() {
        return _randomPrompt;
    }
    public int GetNumListedItems() {
        return _numItems;
    }
}