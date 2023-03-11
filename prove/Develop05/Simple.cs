using System;
public class Simple : Goal
{
    private Boolean _fullycompletedSimple = true;

    public Simple(string goalName, string goalDescription, int pointsGoal) : base(goalName, goalDescription, pointsGoal){
    }
    public Simple() {
        
    }
    // //Methods
    public Boolean completed() {
        return _fullycompletedSimple;
    }
   
    // public override int CalculateScore() {
    //     return _simpleScore;
    // }
    // public override void RecordEvent(int pointValue) {
    //     Console.WriteLine("salvar item na lista!");
    // }
    // public override Boolean IsComplete(Boolean complete) {
    //     complete = true;
    // }
}