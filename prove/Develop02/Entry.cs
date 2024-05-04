using System;

public class Entry
{
    public DateTime Date;
    public string PromptText;
    public string EntryText;

    public Entry(DateTime date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"On {Date} -- {PromptText}: \n {EntryText}");
    }
}