using System;

public class Breathing : Activity {
    private string _breathIn = "Breath In...";
    private string _breathOut = "Breath Out...";

    public Breathing(string name, string description) : base(name, description) {

    }
    public void RunBreathingActivity() {
        for (int i = 0; i <= 4; i++)
        {
            BreathIn();
            BreathOut();
        }
    }
    public void BreathIn() {
        Console.Write($"\b{_breathIn}5");
        Thread.Sleep(1000);
        Console.Write($"\b{_breathIn}4");
        Thread.Sleep(1000);
        Console.Write($"\b{_breathIn}3");
        Thread.Sleep(1000);
        Console.Write($"\b{_breathIn}2");
        Thread.Sleep(1000);
        Console.Write($"\b{_breathIn}1");
        Thread.Sleep(1000);
    }
    public void BreathOut() {
        Console.Write($"\b{_breathOut}5");
        Thread.Sleep(1000);
        Console.Write($"\b{_breathOut}4");
        Thread.Sleep(1000);
        Console.Write($"\b{_breathOut}3");
        Thread.Sleep(1000);
        Console.Write($"\b{_breathOut}2");
        Thread.Sleep(1000);
        Console.Write($"\b{_breathOut}1");
        Thread.Sleep(1000);
    }
}