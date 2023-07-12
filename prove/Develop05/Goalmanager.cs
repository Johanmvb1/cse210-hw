using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public GoalManager()
    {
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public void AddBonus(int bonusPoints)
    {
        _totalPoints += bonusPoints;
    }

    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public List<Goal> GetGoalsList()
    {
        return _goals;
    }

    public void ListGoals()
    {
        if (_goals.Count()>0)
        {
            Console.WriteLine(" Your Goal is: ");

            int index = 1;
            foreach(Goal goal in _goals)
            {
                goal.ListGoal(index);
                index=index + 1;
            }
        }
        else
        {
            Console.WriteLine(" Your dont have any Goal");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();

        Console.WriteLine(" Which goal you completed?");
        int select = int.Parse(Console.ReadLine())-1;
        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);
        Console.WriteLine($"Your Total is {GetTotalPoints()}");
    }
    public void SaveGoals()
    {
        Console.WriteLine("type the name for your goal file");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(GetTotalPoints());
            foreach (Goal gaol in _goals)
            {
                outputFile.WriteLine(gaol.SaveGoal());
            }

        }
    }

    public void LoadGoals()
    {
        Console.WriteLine(" What is the name of the Goal? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);
            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            readText = readText.Skip(1).ToArray();

            foreach ( string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(sGoal);
                }

                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
                

            }


        }

    }
}