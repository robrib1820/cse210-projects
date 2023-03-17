using System;
public class Simple : Goal
{
    private Boolean _fullycompletedSimple = false;
    public Simple() {
        
    }
    // //Methods
    public override string ReturnList() {
        string name = GetGoalName();
        string description = GetGoalDescription();
        _goalToAdd = ($"[ ] {name} : {description}");
        
        if (IsComplete() == true)
        {
            _goalToAdd = ($"[x] {name} : {description}");
        }
        
        return _goalToAdd;
    }
    public override Boolean IsComplete() {
        return _fullycompletedSimple = true;
        
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
}