
class Entry
{
    
    public string date, promptText, entryText;

    public Entry(string _date, string _prompText, string _entryText)
    {

        date       = _date;
        promptText = _prompText;
        entryText  = _entryText;

    }

    public void Display()
    {

        Console.WriteLine($"Date: {date} - Prompt: {promptText}");
        Console.WriteLine(entryText);
    }

}