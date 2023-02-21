using System;

public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private string _randomPrompt;
    private string _randomQuestionPrompt;
    public Reflecting(string name, string description) : base(name, description) {

    }
    public void RunsReflectingActivity() {

    }
    public string GetRandomPrompt() {
        return _randomPrompt;
    }
    public string GetRandomQuestionPrompt() {
        return _randomQuestionPrompt;
    }
    public void SetRandomPrompt(string prompt) {
        _randomPrompt = prompt;
    }
    public void SetRandomQuestionPrompt(string questionPrompt) {
        _randomQuestionPrompt = questionPrompt;
    }


}