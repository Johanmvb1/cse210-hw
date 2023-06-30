using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSumary());

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");
        Console.WriteLine(a2.GetSumary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine(a3.GetSumary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}