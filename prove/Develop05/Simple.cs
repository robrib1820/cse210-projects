using System;
public class Simple : Goal
{
    private Boolean _fullycompletedSimple = true;
    private List<string> _listGoalsSimple = new List<string>();

    public Simple(string goalName, string goalDescription, int pointsGoal) : base(goalName, goalDescription, pointsGoal){
    }
    public Simple() {
        
    }
    // //Methods
    public void AddToList() {
        _listGoalsSimple.Add($"({GetGoalName()} {GetGoalDescription()}");
    }
    public Boolean completed() {
        return _fullycompletedSimple;
    }
    public override void ReturnList() {
        Console.WriteLine(_listGoalsSimple[0]);
    }
   
    // public override int CalculateScore() {
    //     return _simpleScore;
    // }
    public override void RecordEvent() {
        Console.WriteLine("salvar item na lista!");
    }
    // public override Boolean IsComplete(Boolean complete) {
    //     complete = true;
    // }
}