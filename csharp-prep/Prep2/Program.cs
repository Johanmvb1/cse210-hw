using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your grade? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        int F = 59;
        int D = 60;
        int C = 70;
        int B = 80;
        int A = 90;


        if (grade <= F )
        {
            Console.WriteLine("Your grade is F" );
        }
        else if ( grade >= D && grade < C )
        {
            Console.WriteLine("Your grade is D" );

        }
        else if ( grade >= C && grade < B )
        {
            Console.WriteLine("Your grade is C" );
        }
        else if ( grade >= B && grade < A )
        {
            Console.WriteLine("Your grade is B" );
        }
        else if (grade >= A )
        {
             Console.WriteLine("Your grade is A" );
        }


    }
}