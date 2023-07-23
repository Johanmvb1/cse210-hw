using System;

public class MainMenu : Menu
{
    // Attributes
    private new string _menu = $@"
             Main Menu Options
Please select one of the following options:
1. Play Game
2. Quit.
Select a option form the menu";

    private string _welcome = "Welcome to Hangman";
    private string _goodbye = "bye (╯╭╮╰)";


    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        Menu gameMenu = new GameMenu();
        PrintWelcome(); 

        while (_action != 2)
        {
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    Console.Clear();
                    gameMenu.MenuChoice();
                    break;
                case 2:
                    PrintGoodbye();
                    break;
                default:
                    Console.WriteLine($"\n Not a valid option.");
                    break;
            }
        }
    }
    private void PrintWelcome()
    {
        Console.Clear();
        Console.Write($"{_welcome}\n\n");
    }
    private void PrintGoodbye()
    {
        Console.Clear();
        Console.Write($"{_goodbye}\n\n");
    }
}