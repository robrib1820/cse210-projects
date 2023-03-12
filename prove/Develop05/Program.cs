using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean menu = true;
        int option = 0;
        int points = 0;
        while (menu == true)
        {
            Console.WriteLine($"You have {points} points!");   
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
            

            if (option == 6) 
            {
                menu = false;
            }
            else if (option == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. CheckList Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalChoice = Console.ReadLine();
                int goalOption = int.Parse(goalChoice);


                Console.WriteLine("What is the name of your goal? ");
                string goalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                string pointsGoal = Console.ReadLine();
                int pointsOfGoal = int.Parse(pointsGoal);

                if (goalOption == 1)
                {
                    Simple goal = new Simple(goalName, goalDescription, pointsOfGoal);
                    
                }
                else if (goalOption == 2)
                {
                    Eternal goal = new Eternal(goalName, goalDescription, pointsOfGoal);
                }
                else if (goalOption == 3)
                {
                    CheckList goal = new CheckList(goalName, goalDescription, pointsOfGoal);
                }
                else{
                    Console.WriteLine("Please, select a correct option!");
                }
            }
            else if (option == 2)
            {   
                List<Goal> listOfGoals = new List<Goal>();
                Simple simpleGoal = new Simple();
                Eternal eternalGoal = new Eternal();
                CheckList checkListGoal = new CheckList();
                listOfGoals.Add(simpleGoal);
                listOfGoals.Add(eternalGoal);
                listOfGoals.Add(checkListGoal);
                simpleGoal.ReturnList();
                eternalGoal.ReturnList();
                checkListGoal.ReturnList();
                foreach (Goal goal in listOfGoals)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("YOU LIST ARE");
                    // Console.WriteLine(goal.ReturnList());
                    Console.WriteLine("--------------------------------");
                }
                
            }
        }


    }
}
