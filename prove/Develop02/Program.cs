using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        string prompt = promptGenerator.GetPrompt();

        Console.WriteLine($"{DateTime.Today} --- {prompt}");
        
        string entry = Console.ReadLine();

        Entry entry1 = new Entry(DateTime.Today, prompt, entry);

        entry1.Display();

        journal.AddEntry(entry1);
        //Before this, get user filename
        journal.SaveToFile("journal.txt");


    }
}