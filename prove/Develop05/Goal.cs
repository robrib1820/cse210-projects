using System;

public  abstract class  Goal
{
    private int _score = 0;
    private string _goalName;
    private string _goalDescription;
    
    private int _awardedPoints;
    private List<Goal> _listGoals = new List<Goal>();

    //Methods
    public Goal() {

    }
    public Goal(string goalName, string goalDescription, int pointsGoal) {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _awardedPoints = pointsGoal;
    }
    //Getters and Setters
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

    public int GetGoalPoins() {
        return _awardedPoints;
    }
    public void SetGoalPoints(int points) {
        _awardedPoints = points;
    }

    public List<Goal> GetListGoal() {
        return _listGoals;
    }
    public List<Goal> SetListGoal(List<Goal> goal) {
         return _listGoals = goal;
    }
    public abstract void ReturnList();

    // public abstract int CalculateScore();
    public abstract void RecordEvent();
    // public  abstract Boolean IsComplete(Boolean complete);

}