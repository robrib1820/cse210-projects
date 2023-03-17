using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalsList = new List<Goal>();
        List<int> pointsList = new List<int>();
        Boolean menu = true;
        int option = 0;
        int points = 0;
        while (menu == true)
        {
            Console.WriteLine($"You have {points} points!");  
            Console.WriteLine(); 
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            option = int.Parse(choice);
            

            if (option == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. CheckList Goal");
                Console.Write("Which type of goal would you like to create? ");
                string Opt = Console.ReadLine();
                int goalOption = int.Parse(Opt);
                

                if (goalOption == 1)
                {
                    Simple goal = new Simple();
                    Console.WriteLine("What is the name of your goal? ");
                    goal.SetGoalName(Console.ReadLine());
                    Console.WriteLine("What is a short description of it? ");
                    goal.SetGoalDescription(Console.ReadLine());
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string pointsGoal = Console.ReadLine();
                    goal.SetPointsGoal(int.Parse(pointsGoal));
                    goalsList.Add(goal);
                }
                else if (goalOption == 2)
                {
                    Eternal goal = new Eternal();
                    Console.WriteLine("What is the name of your goal? ");
                    goal.SetGoalName(Console.ReadLine());
                    Console.WriteLine("What is a short description of it? ");
                    goal.SetGoalDescription(Console.ReadLine());
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string pointsGoal = Console.ReadLine();
                    goal.SetPointsGoal(int.Parse(pointsGoal));
                    goalsList.Add(goal);
                }
                else if (goalOption == 3)
                {
                    CheckList goal = new CheckList();
                    Console.WriteLine("What is the name of your goal? ");
                    goal.SetGoalName(Console.ReadLine());
                    Console.WriteLine("What is a short description of it? ");
                    goal.SetGoalDescription(Console.ReadLine());
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    string pointsGoal = Console.ReadLine();
                    goal.SetPointsGoal(int.Parse(pointsGoal));
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    string pointBonus = Console.ReadLine();
                    goal.SetBonusPoint(int.Parse(pointBonus));
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    string pointBonus2 = Console.ReadLine();
                    goal.SetTimesCompleted(int.Parse(pointBonus2));
                    goalsList.Add(goal);
                }
                else{
                    Console.WriteLine("Please, select a correct option!");
                }
            }
            else if (option == 2)
            {   
                int counter = 1;
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Your goals are: ");
                foreach( Goal goalItem in goalsList)
                {
                    Console.WriteLine($"{counter}. {goalItem.GetTheGoal()}");
                    counter ++;
                }
                Console.WriteLine("--------------------------------------------------------");
            }
            else if (option == 5)
            {
                int counter = 1;
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Your goals are: ");
                foreach( Goal goalItem in goalsList)
                {
                    Console.WriteLine($"{counter}. {goalItem}");
                    counter ++;
                }
                Console.WriteLine("--------------------------------------------------------");
                Console.Write("Which goal did you accomplish? ");
                string accomplishedGoal = Console.ReadLine();
                int accomplished = int.Parse(accomplishedGoal);
                
                


                Console.WriteLine($"You earned {pointsList[accomplished - 1]} points!");
                points += pointsList[accomplished - 1];
                Console.WriteLine($"You now have {points}.");
                Console.WriteLine();

            }
            else if (option == 6) 
            {
                menu = false;
            }
        }


    }
}
