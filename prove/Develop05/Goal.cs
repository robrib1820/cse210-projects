using System;

public abstract class  Goal
{
    private string _goalName;
    private string _goalDescription;
    
    private int _awardedPoints;

    //Methods
    public Goal() {

    }
    public Goal(string goalName, string goalDescription, int pointsGoal) {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _awardedPoints = pointsGoal;
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
    // public int GetGoalPoins() {
    //     return _awardedPoints;
    // }
    // public void SetGoalPoints(int points) {
    //     _awardedPoints = points;
    // }
    public void testProgram() {
        Console.WriteLine($"This is your goal: {_goalName}");
    }
    
    public abstract string AddToList();
    public abstract int AddPointsToList();
   
    // public abstract void ReturnList();

    // // public abstract int CalculateScore();
    public abstract string RecordEvent();
    // // public  abstract Boolean IsComplete(Boolean complete);

}