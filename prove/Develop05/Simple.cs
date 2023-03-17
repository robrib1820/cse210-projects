using System;
public class Simple : Goal
{
    private Boolean _fullycompletedSimple = true;
    public Simple() {
        
    }
    
    
    // //Methods
    
    
    public Boolean completed() {
        return _fullycompletedSimple;
    }
    public override string GetTheGoal() {
        string name = GetGoalName();
        string description = GetGoalDescription();
        string goalToAdd = ($"[ ] {name} : {description}");
        return goalToAdd;
    }
    // public override void ReturnList() {
    //     Console.WriteLine(_listGoalsSimple[0]);
    // }
   
    // // public override int CalculateScore() {
    // //     return _simpleScore;
    // // }
    public override string RecordEvent() {
        string completed = "[X]";
        return completed;
    }
    // public override Boolean IsComplete(Boolean complete) {
    //     complete = true;
    // }
}