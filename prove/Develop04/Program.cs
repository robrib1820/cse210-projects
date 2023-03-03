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
                Breathing main = new Breathing("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                int breathing = 0;
                main.DisplayStartMessage();
                main.BeReady();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(main.GetDurantionSeconds());
                Console.Clear();
                while (DateTime.Now < futureTime) 
                {
                    main.RunBreathingActivity();
                }
                main.DisplayEndMessage();
                breathing +=1;
            }
            else if (option == "2")
            {
                Reflecting main = new Reflecting("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                int reflecting = 0;
                main.DisplayStartMessage();
                main.BeReady();
                main.DisplayPrompt();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(main.GetDurantionSeconds());
                Console.Clear();
                while (DateTime.Now < futureTime) 
                {
                    main.RunReflectingActivity();
                }
                main.DisplayEndMessage();
                reflecting +=1;
            }
            else if (option == "3")
            {
                Listing main = new Listing("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                int listing = 0;
                main.DisplayStartMessage();
                main.BeReady();
                main.DisplayPrompt();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(main.GetDurantionSeconds());
                main.PauseSpinner();
                while (DateTime.Now < futureTime)
                {
                    main.RunListingActivity();
                }
                main.GetNumbPrompts();
                main.DisplayEndMessage();
                listing +=1;
            }
            else 
            {
                menu = false;
                // Console.WriteLine("NUmber of times you performed each activity: ");
                // Console.WriteLine($"Breathing Activity: {breathing}");
                // Console.WriteLine($"Reflecting Activity: {reflecting}");
                // Console.WriteLine($"Listing Activity: {listing}");
                // sessionTime.testeFunction();
            }

        }
    }
}