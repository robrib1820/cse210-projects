using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your percentage grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number < 60 )
        {
            string fGrade = "F";
            Console.WriteLine($"Your grade is {fGrade}");
        }
        else if (number < 70 )
        {
            string dGrade = "D";
            Console.WriteLine($"Your grade is {dGrade}");
        }
        else if (number < 80 )
        {
            string cGrade = "C";
            Console.WriteLine($"Your grade is {cGrade}");
        }
        else if (number < 90 )
        {
            string bGrade = "B";
            Console.WriteLine($"Your grade is {bGrade}");
        }
        else
        {
            string aGrade = "A";
            Console.WriteLine($"Your grade is {aGrade}");
        }
        
        if (number < 70)
        {
            Console.Write("You need to study more!");
        }
        else
        {
            Console.Write("Congratulations. You completed the course!");
        }
    }
}