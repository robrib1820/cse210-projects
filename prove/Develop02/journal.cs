using System;

public class Journal 
{
    public void Display() {
        Boolean prompts = false;
        while (prompts == false) {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you like to do? ");
            string prompt = Console.ReadLine();
            int number = int.Parse(prompt);
            if (number == 1) {
                AddEntry();
            }
            if (number == 2) {
                //DisplayEntries();
            }
            if (number == 3) {
                //LoadFile();
            }
            if (number == 4) {
                //SaveFile();
            }
            if (number == 5) {
                prompts = true;
                Console.Write("Thank you for recording today! See you next time!");
            }
        }
    }
    public void AddEntry() {
        Prompt question = new Prompt();
        question.QuestionPrompt();
    }

    public void DisplayEntries() {
        Prompt entries = new Prompt();
        entries.QuestionPrompt();

        foreach (string entry in entries.QuestionPrompt()) {
            
        }
    }
}
