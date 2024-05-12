using System;

public class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Proverbs 3:5-6","Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        
        scripture.DisplayScripture();

        string input = string.Empty;
        while (input != "Quit")
        {
            scripture.HideRandomVerses();
            input = Console.ReadLine();
        }
    }
}