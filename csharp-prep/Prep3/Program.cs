using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 101);
        bool game = false;
        /*Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);*/
        int counter = 1;
        
        while (game == false)
        {
            Console.Write("What is you guess? ");
            string guessNumber = Console.ReadLine();
            int guess = int.Parse(guessNumber);
            counter++;
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("Congratulations. It got it!");
                game = true;
            }
        }
        Console.Write($"You guess it with {counter -1} tries!");
    }
}