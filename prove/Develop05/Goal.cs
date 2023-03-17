using System;

public abstract class  Goal
{
    private string _goalName;
    private string _goalDescription;
    
    private int _awardedPoints;
    protected string _goalToAdd;

    //Methods
    
    public Goal() {

    }
    //Getters and Setters
    public int PointsOfGoal() {
        return _awardedPoints;
    }
    public void SetPointsGoal(int points) {
        _awardedPoints = points;
    }
    public string GetGoalName() {
        return _goalName;
    }
    public void SetGoalName(string goalName) {
        _goalName = goalName;
    }

    public string GetGoalDescription() {
        return _goalDescription;
    }
    public void SetGoalDescription(string goalDescription) {
        _goalDescription = goalDescription;
    }
    public abstract string ReturnList();
    
    // public void SetGoalPoints(int points) {
    //     _awardedPoints = points;
    // }
    

    // // public abstract int CalculateScore();
    public abstract string RecordEvent();
    public  abstract Boolean IsComplete();

}