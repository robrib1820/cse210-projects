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
    //     Console.WriteLine(_listGoalsSimple[0]);
    // }
   
    // // public override int CalculateScore() {
    // //     return _simpleScore;
    // // }
    // public override void RecordEvent() {
    //     Console.WriteLine("salvar item na lista!");
    // }
    // public override Boolean IsComplete(Boolean complete) {
    //     complete = true;
    // }
}