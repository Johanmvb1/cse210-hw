using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);

        int userNumber  = -1;
        Console.WriteLine("Guess a number from 1 to 10");


        while (userNumber != number)
        {
            
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber == number)
            {
                Console.WriteLine("Your number is correct! ");
            }
            else if (userNumber <= number)
            {
                Console.WriteLine("Try a higher number ");

            }
            else if( userNumber >= number)
            {
                Console.WriteLine("Try a lower number");
            }
            
        }
    }
}