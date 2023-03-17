using System;

public class Eternal : Goal
{
    private Boolean _fullycompletedEternal = false;
    public Eternal() {

    }
    // //Methods
    public override string ReturnList() {
        string name = GetGoalName();
        string description = GetGoalDescription();
        if (_fullycompletedEternal == false)
        {
            _goalToAdd = ($"[ ] {name} : {description}");
        } else 
        {
            _goalToAdd = ($"[X] {name} : {description}");
        }
        return _goalToAdd;
    }
    public override string RecordEvent() {
        string completed = "[X]";
        return completed;
    }
    public override Boolean IsComplete() {
        return _fullycompletedEternal;
    }
}