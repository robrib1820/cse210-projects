using System;

public class Breathing : Activity {
    private string _breatheIn = "Breathe In...";
    private string _breatheOut = "Now breathe Out...";

    public Breathing(string name, string description) : base(name, description) {

    }
    public void RunBreathingActivity() {
        BeReady();
        for (int i = 0; i <= 4; i++)
        {
            BreathIn();
            Console.WriteLine();
            BreathOut();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    public void BreathIn() {
        Console.Write($"\b{_breatheIn}5");
        Thread.Sleep(1000);
        Console.Write($"\b4");
        Thread.Sleep(1000);
        Console.Write($"\b3");
        Thread.Sleep(1000);
        Console.Write($"\b2");
        Thread.Sleep(1000);
        Console.Write($"\b1");
        Thread.Sleep(1000);
    }
    public void BreathOut() {
        Console.Write($"\b{_breatheOut}5");
        Thread.Sleep(1000);
        Console.Write($"\b4");
        Thread.Sleep(1000);
        Console.Write($"\b3");
        Thread.Sleep(1000);
        Console.Write($"\b2");
        Thread.Sleep(1000);
        Console.Write($"\b1");
        Thread.Sleep(1000);
    }
}