using System;

public class Prompt
{
    string[] _questions = {"What was the best part of your day?", "What should you have done better?",
    "What did you eat today?", "How was your workday?", "What spiritual experience marked you today?"  };

    public string QuestionPrompt() {
        Random question = new Random();
        int index = question.Next(_questions.Length);
        Console.WriteLine(_questions[index]);
        string theQuestion = Console.ReadLine();
        return theQuestion;
    }
}