using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> goalsList = new List<string>();
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
            Simple goal = new Simple();
            Eternal goal2 = new Eternal();
            CheckList goal3 = new CheckList();
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
                    goal.TypeOfGoals();
                    goalsList.Add(goal.AddToList());
                    pointsList.Add(goal.AddPointsToList());

                }
                else if (goalOption == 2)
                {
                    goal2.TypeOfGoals();
                    goal2.AddToList();
                    goalsList.Add(goal2.AddToList());
                    pointsList.Add(goal2.AddPointsToList());
                    
                }
                else if (goalOption == 3)
                {
                    goal3.TypeOfGoals();
                    goalsList.Add(goal3.AddToList());
                    pointsList.Add(goal3.AddPointsToList());
                    
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
                foreach( string goalItem in goalsList)
                {
                    Console.WriteLine($"[ ] {counter}. {goalItem}");
                    counter ++;
                }
                Console.WriteLine("--------------------------------------------------------");
            }
            else if (option == 5)
            {
                int counter = 1;
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Your goals are: ");
                foreach( string goalItem in goalsList)
                {
                    Console.WriteLine($"[ ] {counter}. {goalItem}");
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
