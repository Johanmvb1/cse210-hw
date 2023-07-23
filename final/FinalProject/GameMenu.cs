using System;

public class GameMenu : Menu
{
    private new string _menu = $@"
                Game Options
===========================================
Your Game Options are:
1. Random Words
2. Back to Main Menu
3.quit
===========================================
Which game would you like to play?  ";

    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        Menu listMenu = new ListMenu();

        while (_action != 3)
        {
            _action = UserChoice();
            switch (_action)
            {
                case 1:
        
                    _wordFileName = "words.txt";
                    Hangman game = new Hangman();
                    game.StartGame(_wordFileName);
                    break;
                case 2:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine($"\n Not a valid option.");
                    break;
            }
        }
    }
}