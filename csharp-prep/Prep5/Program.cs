using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcomeMessage();
        string userName = PersonalName();
        int userNumber = FavoriteNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResults(userName,squareNumber);


        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("welcome to the program");
        }
    }

    static string PersonalName()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        return name;
    }
    
    static int FavoriteNumber()
    {
        Console.WriteLine("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        
        return number;
    }

    static int SquareNumber( int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, The square of your number is {square}");
    }


}
