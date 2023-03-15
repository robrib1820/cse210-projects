using System;

public class CheckList : Goal
{
    
    private int _bonusPoint;
    private int _timesCompleted;
    private int _counterGoal;
    private Boolean fullycompletedCheck;
    protected List<string> _listGoalsCheck = new List<string>();
    
    public CheckList() {

    }
    public CheckList(string goalName, string goalDescription, int pointsGoal) : base(goalName, goalDescription, pointsGoal){

    }
    
    // //Methods
    public override string AddToList() {
        string goalToList = ($"{GetGoalName()}: {GetGoalDescription()}");
        return goalToList;
    }
    public override int AddPointsToList() {
        int points = PointsOfGoal();
        return points;
    }
    public override void TypeOfGoals() {
        Console.WriteLine("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is a short description of it? ");
        SetGoalDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal? ");
        string pointsGoal = Console.ReadLine();
        SetPointsGoal(int.Parse(pointsGoal));
    }
    // public override void ReturnList() {
    //     Console.WriteLine(_listGoalsCheck[0]);
    // }
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
    // public override void RecordEvent() {
    //     Console.WriteLine("salvar item na lista!");
    // }
    // public override Boolean IsComplete(Boolean complete) {
    //     complete = true;
    // }
}