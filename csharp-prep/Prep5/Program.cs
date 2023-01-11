using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int sqNum = SquareNumber(favNumber);
        DisplayResult(userName, sqNum);
        
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
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static int SquareNumber(int number)
    {
        int sqNumber = number * number;
        return sqNumber;
    }
    static void DisplayResult( string name, int sqNumber)
    {
        Console.WriteLine($"Your name is {name}, and the square of your number is {sqNumber} ");
    }
}