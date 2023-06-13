using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Sofware Engineer";
        job1._company = "Micron";
        job1._startYear = 2020;
        job1._endYear = 2021;

        job1.DisplayJobDetails();

        job Job2 = new job();
        Job2._jobTitle ="Senior Engineer";
        Job2._company ="TSMC";
        Job2._startYear = 2021;
        Job2._endYear = 2023;

        Job2.DisplayJobDetails();

        Resume Xresume = new Resume();
        Xresume._name = "Johan Villarreal";

        








    }
}