using System;

public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        };

    private int _randomPromptNumber;
    private int _randomPromptQuestionNumber;
    private string _randomPrompt;
    private string _randomQuestionPrompt;
    public Reflecting(string name, string description) : base(name, description) {

    }
    public void RunReflectingActivity() {
        Console.WriteLine($"> {_questions[GetRandomQuestionPromptNumber()]}");
        MiniSpinner(8);
        Console.WriteLine($"> {_questions[GetRandomQuestionPromptNumber()]}");
        MiniSpinner(8);
    }
    public int GetRandomPromptNumber() {
        Random num = new Random();
        _randomPromptNumber = num.Next(_prompts.Count);
        return _randomPromptNumber;
    }
    public string GetRandomPrompt() {
        return _randomPrompt;
    }
    public int GetRandomQuestionPromptNumber() {
        Random num = new Random();
        _randomPromptQuestionNumber = num.Next(_questions.Count);
        return _randomPromptQuestionNumber;

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
    
    public void DisplayPrompt() {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[GetRandomPromptNumber()]} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        PauseCountdownTimer();
    }
}