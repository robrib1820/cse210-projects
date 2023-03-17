using System;
public class Simple : Goal
{
    private Boolean _fullycompletedSimple = true;
    private List<string> _listGoalsSimple = new List<string>();
    public Simple() {
        
    }
    public Simple(string goalName, string goalDescription, int pointsGoal) : base(goalName, goalDescription, pointsGoal){
    }
    
    // //Methods
    
    
    public Boolean completed() {
        return _fullycompletedSimple;
    }
    public override string AddToList() {
        string goalToList = ($"{GetGoalName()}: {GetGoalDescription()}");
        return goalToList;
    }
    public override int AddPointsToList() {
        int points = PointsOfGoal();
        return points;
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