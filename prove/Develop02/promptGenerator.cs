class promptGenerator 
{
    List<string> prompts;

    public promptGenerator()
    {
       prompts = new List<string> 
       {
         "Who was the most interesting person I interacted with today?",
         "What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?",
         "What was the stringest emotion I gelt today?",
         "If i had one thing I could do over today, what would it be?"
       };  
    }

    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex = new Random().Next(prompts.Count);

        randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
}