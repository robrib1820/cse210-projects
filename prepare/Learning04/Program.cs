using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennter", "Multiplication");
        string assigs = assignment.GetSummary();
        Console.WriteLine(assigs);
        Console.WriteLine("-----------------------------");
        MathAssignment math = new MathAssignment("Section 7.5", "Problems 3-12", "Robson Ribeiro", "Fractions");
        string mathAssigs = math.GetSummary();
        Console.WriteLine(mathAssigs);
        string mathProblems = math.GetHomewokList();
        Console.WriteLine(mathProblems);
        WritingAssignment writing = new WritingAssignment("Karlyn Eliza", "European History", "The Causes of World War II by Mary Waters");
       string write = writing.GetSummary();
       string writingInfo = writing.GetWritingInformation();
       Console.WriteLine("--------------------------------");
       Console.WriteLine(write);
       Console.WriteLine(writingInfo);
    }
}