using System;

<<<<<<< HEAD
public class PromptGenerator {
    
=======
public class Prompt
{
    string[] _promptList = {
        "What was the best part of your day?",
        "What should you have done better?",
        "What did you eat today?", 
        "How was your workday?", 
        "What spiritual experience marked you today?"
        };

    
    public int GenerateRandomNUmber() {
        Random randomNumber = new Random();
        int numb = randomNumber.Next(1, 5);
        return numb;
    }
    public void QuestionGenerator() {
        Console.WriteLine(_promptList[GenerateRandomNUmber()]);
        // string question = Console.ReadLine();
        // return question;
    }
>>>>>>> 17f85f8f4249ec6ba29750f4b8714af7a7491c0f
}