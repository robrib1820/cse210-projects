using System;

public class CheckList : Goal
{
    private int _bonusPoint;
    private int _timesCompleted;
    private int _counterGoal;
    private Boolean _fullycompletedCheck = false;
    
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
    public int GetCounterGoal() {
        return _counterGoal;
    }
    public void SetCounterGoal(int CounterGoal) {
        _counterGoal = CounterGoal;
    }
    public override string ReturnList() {
        string name = GetGoalName();
        string description = GetGoalDescription();
        int completed = GetTimesCompleted();
        int counter = GetCounterGoal();
        if (_fullycompletedCheck == false)
        {
            _goalToAdd = ($"[ ] {name} : {description} -- Currently Completed: {completed} / {counter}");
        } else 
        {
            _goalToAdd = ($"[ ] {name} : {description} -- Currently Completed: {completed} / {counter}");
        }
        return _goalToAdd;
    }
    public override string RecordEvent() {
        string completed = "[X]";
        return completed;
    }
    public override Boolean IsComplete() {
        return _fullycompletedCheck = true;
    }
    public override string SaveGoal() {
        string name = GetGoalName();
        string description = GetGoalDescription();
        int points = PointsOfGoal();
        string savedGoal = ($"'CheckList',{name},{description},{points},{_timesCompleted}, {_counterGoal}, {_bonusPoint}");
        return savedGoal;
    }
}