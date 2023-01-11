using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        int favNumber = PromptUserNumber();
        Console.Write(SquareNumber(favNumber));
        Console.ReadLine();
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string nAme = Console.ReadLine();
        return nAme;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favNumber = int.Parse(Console.Read());
        return favNumber;
    }
    static int SquareNumber(int number)
    {
        int sqNumber = number * number;
        return sqNumber;
    }
}