using System;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();

        int userNumber= -1;
        
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the Sum is: {sum}");

        float averageNumber = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average number is: {averageNumber}");

        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($" the max is: {max}");
    }
}