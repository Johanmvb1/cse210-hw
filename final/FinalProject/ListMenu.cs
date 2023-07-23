using System;

public class ListMenu : Menu
{
    // Attributes 
    private new string _menu = $@"
        List Options
Your list Options are:
1. Video-games.
2. Movies.
3. all time latin music.
4. back to menu.
Which list would you like to use?  ";


    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        while (_action != 4)
        {
            Hangman game = new Hangman();
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    _wordFileName = "videoGames.txt";
                    game.StartGame(_wordFileName);
                    break;
                case 2:
                    _wordFileName = "allTimeMovies.txt";
                    game.StartGame(_wordFileName);
                    break;
                case 3:
                    _wordFileName = "LatinMusic.txt";
                    game.StartGame(_wordFileName);
                    // no despacito pls 
                    break;
                case 4:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}