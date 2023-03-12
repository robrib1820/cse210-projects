using System;

public class Eternal : Goal
{
    private Boolean _fullycompletedSimple = false;
    protected List<string> _listGoalsEternal = new List<string>();
    public Eternal() {

    }
    
    public Eternal(string goalName, string goalDescription, int pointsGoal) : base(goalName, goalDescription, pointsGoal){

    }
    
    // //Methods
    public void AddToList() {
        _listGoalsEternal.Add($"({GetGoalName()} {GetGoalDescription()}");
    }
    public Boolean completed() {
        return _fullycompletedSimple;
    }
    public override void ReturnList() {
        Console.WriteLine(_listGoalsEternal[0]);
    }
    // public override int CalculateScore() {
    //     return _eternalScore;
    // }
    // public override void RecordEvent(int pointValue) {
    //     Console.WriteLine("salvar item na lista!");
    // }
    // public override Boolean IsComplete(Boolean complete) {
    //     complete = true;
    // }
}