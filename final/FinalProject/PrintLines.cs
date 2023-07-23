using System;
using System.Collections.Generic;
using System.Text;

public class PrintLines
{

    public void GetLines(String randomWord)
        {
            Console.Write("\r");
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.Write("\u005f "); 
            }
        }

}