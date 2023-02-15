using System;

class Program
{
    static void Main(string[] args)
    {
        string scripture_text = "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.";
        Reference reference = new Reference();
        string reference_text = reference.GetReference();
        Scripture scripture = new Scripture(reference_text, scripture_text);
        Boolean option = true;
        while (option == true) 
        {
            scripture.GetScriptureText();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string answer = Console.ReadLine();
            if (answer == "quit")
            {
                option = false;
            }
            Word word = new Word();
            word.GetRenderedText(scripture.list());
            word.Hide();
        }
    }
}