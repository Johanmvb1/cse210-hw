using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your First name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("what is your Last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {firstName} {lastName}");


    }
}