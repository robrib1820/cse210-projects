using System;

public class Prompt
{
    string[] _promptList = {
        "What was the best part of your day?",
        "What should you have done better?",
        "What did you eat today?", 
        "How was your workday?", 
        "What spiritual experience marked you today?"
        };

    
    public void QuestionPrompt() {
        for ( int prompt = 0; prompt < 5; prompt++){
            _promptList[prompt];   
        }
        
    }


}