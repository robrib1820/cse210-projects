using System;

public  abstract class  Goal
{
    protected int _score = 0;
    protected string _goalName;
    protected string _goalDescription;
    
    protected int _awardedPoints;
    protected List<Goal> _listGoals = new List<Goal>();

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

    // public abstract int CalculateScore();
    // public abstract int RecordEvent(int pointValue);
    // public  abstract Boolean IsComplete(Boolean complete);

}