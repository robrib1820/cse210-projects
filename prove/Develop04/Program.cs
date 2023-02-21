using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean menu = true;
        while (menu == true) 
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string option = Console.ReadLine();

            if (option == "1")
            {
                Activity main = new Activity();
                main.DisplayStartMessage();
                main.PauseSpinner();
                main.DisplaEndMessage();
            }

        }
    }
}