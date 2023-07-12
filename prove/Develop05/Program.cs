using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        GoalManager goals = new GoalManager();

        Console.Clear(); 
        Console.Write("\n*** Welcome to the Eternal Quest ****\n");

        Console.Write($"\n*** You have {goals.GetTotalPoints()} points ***\n");
        MainMenu choice = new MainMenu();
        GoalMenu goalChoice = new GoalMenu();

        int action = 0;
        while (action != 6)
        {            action = choice.Userchoice();
            switch (action)
            {
                case 1:
                    Console.Clear(); 
                    int goalInput = 0;
                    while (goalInput != 5)
                    {
                        goalInput = goalChoice.GoalSelection();
                        switch (goalInput)
                        {
                            case 1:
                                Console.WriteLine("What is the name of your goal?  ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Describe your goal  ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("how many points on this goal? ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(sGoal);
                                goalInput = 5;
                                break;
                            case 2:
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Describe your goal ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("assing how many pointts for the goal ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eGoal);
                                goalInput = 5;
                                break;
                            case 3:
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Describe the goal  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("Assing how many pointts for the goal ");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("how many times will the goal be accomplish ? ");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("want to assign any bonus ? ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                                goals.AddGoal(clGoal);
                                goalInput = 5;
                                break;
                           
                            case 5:
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.Clear(); 
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.ListGoals();
                    break;
                case 3:
                    goals.SaveGoals();
                    break;
                case 4:
                    // Load Goals
                    Console.Clear(); 
                    Console.Write($"\n***  have {goals.GetTotalPoints()} points ***\n");
                    goals.LoadGoals();
                    break;
                case 5:
                    Console.Clear();
                    Console.Write($"\n*** You  have {goals.GetTotalPoints()} points ***\n");
                    goals.RecordGoalEvent();
                    break;
                case 6:
                    Console.WriteLine("\nThank to use Eternal Quest!\n");
                    break;
                default:
                    Console.WriteLine($"\n Not a valid option.");
                    break;
            }
        }
    }
}