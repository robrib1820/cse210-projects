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
                Activity main = new Activity("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                main.DisplayStartMessage();
                main.PauseSpinner();
                main.DisplayEndMessage();
            }
            else if (option == "2")
            {
                Activity main = new Activity("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                main.DisplayStartMessage();
                main.PauseSpinner();
                main.DisplayEndMessage();
            }
            else if (option == "3")
            {
                Activity main = new Activity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                main.DisplayStartMessage();
                main.PauseSpinner();
                main.DisplayEndMessage();
            }
            else 
            {
                menu = false;
            }

        }
    }
}