using System;

public class Eternal : Goal
{
    private Boolean _fullycompletedSimple = false;
    public Eternal() {

    }
    
    public Eternal(string goalName, string goalDescription, int pointsGoal) : base(goalName, goalDescription, pointsGoal){

    }
    
    // //Methods
    public Boolean completed() {
        return _fullycompletedSimple;
    }
    // public override int CalculateScore() {
    //     return _eternalScore;
    // }
    // public override void RecordEvent(int pointValue) {
    //     Console.WriteLine("salvar item na lista!");
    // }
    // public override Boolean IsComplete(Boolean complete) {
    //     complete = true;
    // }
}