using System.Diagnostics;
class Activity
{
    private string description, name;

    static int spinnerCounter, duration; 

    public Activity()
    {
        spinnerCounter = duration = 0;

    }

    public void SetActivityName(string _ActivityName)
    {
        name = _ActivityName;

    }

    public void SetDescription(string _description)
    {
        description = _description;
    }

    public int GetDuration()
    {
        return duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {name}.");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();

        Console.Write("How long in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

    }

    public void DisplayEndingMEssage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} secons of the {name}. ");
        ShowSpinner(5);

    }

    public void ShowSpinner(int numSecondsToRun)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        while (stopWatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {

            spinnerCounter ++;
            switch (spinnerCounter % 4)
            {
                case 0: Console.WriteLine("/"); break;
                case 1: Console.WriteLine("-"); break;
                case 2: Console.WriteLine("\\"); break;
                case 3: Console.WriteLine("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
        }

    }

    public void ShowCountDown(int numSecondsToRun)
    {

        for(int i = numSecondsToRun; i >= 1; i--)
        {
            Console.Write(string.Format("{0}",i));
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(1000);
        }
        Console.Write("");
        
    }
}