using System;

public class Breathing : Activity {
    private string _breatheIn = "Breathe In...";
    private string _breatheOut = "Now breathe Out...";
    List<string> breathList = new List<string>();
    
    public Breathing(string name, string description) : base(name, description) {
        breathList.Add(_breatheIn);
        breathList.Add(_breatheOut);
    }

    public void RunBreathingActivity() {
        int i = 0;
        string s = breathList[i];
        Console.Write($"\b{breathList[i]}5");
        Thread.Sleep(1000);
        Console.Write($"\b4");
        Thread.Sleep(1000);
        Console.Write($"\b3");
        Thread.Sleep(1000);
        Console.Write($"\b2");
        Thread.Sleep(1000);
        Console.Write($"\b1");
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.Write($"\b{breathList[i+1]}5");
        Thread.Sleep(1000);
        Console.Write($"\b4");
        Thread.Sleep(1000);
        Console.Write($"\b3");
        Thread.Sleep(1000);
        Console.Write($"\b2");
        Thread.Sleep(1000);
        Console.Write($"\b1");
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine();
        i++;
        if (i == breathList.Count) {
            i = 0;
        }
    }
    // public void BreathIn() {
    //     Console.Write($"\b{_breatheIn}5");
    //     Thread.Sleep(1000);
    //     Console.Write($"\b4");
    //     Thread.Sleep(1000);
    //     Console.Write($"\b3");
    //     Thread.Sleep(1000);
    //     Console.Write($"\b2");
    //     Thread.Sleep(1000);
    //     Console.Write($"\b1");
    //     Thread.Sleep(1000);
    // }
    // public void BreathOut() {
    //     Console.Write($"\b{_breatheOut}5");
    //     Thread.Sleep(1000);
    //     Console.Write($"\b4");
    //     Thread.Sleep(1000);
    //     Console.Write($"\b3");
    //     Thread.Sleep(1000);
    //     Console.Write($"\b2");
    //     Thread.Sleep(1000);
    //     Console.Write($"\b1");
    //     Thread.Sleep(1000);
    // }
    // public void test() {
    //     int i = 0;
    //         foreach(string breathe in breathList)
    //     {
    //         string s = breathList[i];
    //         Console.WriteLine(s);
    //         Thread.Sleep(1000);
    //         i++;
    //         if(i >= breathList.Count)
    //         {
    //             i = 0;
    //         }
            
    //     }
    // }
}
