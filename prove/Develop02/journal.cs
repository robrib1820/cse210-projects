using System;
public class Journal 
{
    public string _journalEntry;
    public string _entryDate;
    public string _promptQuestion;
    public void FeatureSelected() {
        Boolean prompts = false;
        Console.WriteLine("Welcome to the Journal Program!");
        while (prompts == false) {
            Console.WriteLine("Ok!");
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
                ShowQuestion();
                string answer = Console.ReadLine();
                Entry entries = new Entry();
                entries._journalEntry = answer;


            }else if (number == 2) {
                Entry list = new Entry();
                list.JournalEntry();
            }else if (number == 3) {
                //LoadFile();
            }else if (number == 4) {
                //SaveFile();
            }else if (number == 5) {
                prompts = true;
                Console.Write("Thank you for recording today! See you next time!");
            }
            else {
                Console.Write("ERROR: Type a valid number!");
            }
        }
    }
    public void DisplayEntries(){
        Console.WriteLine($"Data: {_entryDate}  Question: {_promptQuestion}  Written: {_journalEntry}");
    }
    public void ShowQuestion(){
        PromptGenerator question = new PromptGenerator();
        question.QuestionGenerator();
    }

    public void SaveFile() {

    }
    public void LoadFile() {

    }
    public void CreateFileName() {
        
    }
}
