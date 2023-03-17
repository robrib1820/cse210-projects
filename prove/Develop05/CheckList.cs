using System;

public class CheckList : Goal
{
    
    private int _bonusPoint;
    private int _timesCompleted;
    private int _counterGoal;
    private Boolean fullycompletedCheck;
    
    public CheckList() {

    }
    
    
    // //Methods
    public int GetBonusPoint() {
        return _bonusPoint;
    }
    public void SetBonusPoint(int bonusPoint) {
        _bonusPoint = bonusPoint;
    }
    public int GetTimesCompleted() {
        return _timesCompleted;
    }
    public void SetTimesCompleted(int timesCompleted) {
        _timesCompleted = timesCompleted;
    }
    public int CounterGoal() {
        return _counterGoal;
    }
    public void SetCounterGoal(int CounterGoal) {
        _counterGoal = CounterGoal;
    }
    // public override int CalculateScore() {
    //     return _CheckListScore;
    // }
    public override string GetTheGoal() {
        string name = GetGoalName();
        string description = GetGoalDescription();
        string goalToAdd = ($"[ ] {name} : {description}");
        return goalToAdd;
    }
    public override string RecordEvent() {
        string completed = "[X]";
        return completed;
    }
    // public override Boolean IsComplete(Boolean complete) {
    //     complete = true;
    // }
}