using System;

public class GoalMenu
{
    private string _menu = $@"
    
    Goal menu
    
    Select a type of Goal: 
    1. Simple Goals
    2. Eternal Goals
    3. Checklist Goal
    4. Back to main menu
    ";
    public string _goalInput;
    private int _goalSelection = 0;
     
    public int GoalSelection()
    {
        Console.WriteLine(_menu);
        _goalInput = Console.ReadLine();
        _goalSelection = 0;

        return _goalSelection;
    }
}