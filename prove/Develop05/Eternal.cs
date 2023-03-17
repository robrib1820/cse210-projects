using System;

public class Eternal : Goal
{
    private Boolean _fullycompletedSimple = false;
    public Eternal() {

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
    //     Console.WriteLine(_listGoalsEternal[0]);
    // }
    // // public override int CalculateScore() {
    // //     return _eternalScore;
    // // }
    public override string RecordEvent() {
        string completed = "[X]";
        return completed;
    }
    // public override Boolean IsComplete(Boolean complete) {
    //     complete = true;
    // }
}