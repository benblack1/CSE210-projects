using System;

class Program
{
    static void Main(string[] args)
    {
        //Initialize all variables and constructors and stuffs
        int menuChoice= 100;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string currentDate = DateTime.Today.ToShortDateString();

        //Loop to keep the menu running until 0 is entered
        while (menuChoice != 0)
        {
            Console.WriteLine("\nSelect the number from the following Choices: \n1. Write\n2. Display\n3. Load\n4. Save\n0. Quit");
            string userChoice = Console.ReadLine();
            menuChoice = int.Parse(userChoice);


            //Write a new journal entry option
            if (menuChoice == 1){
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine($"Today is {currentDate} -- {prompt}");
                string userEntry = Console.ReadLine();
                Entry fullEntry = new Entry(currentDate, prompt, userEntry);
                journal.AddEntry(fullEntry);                
            }
            
            //Display all journal entries option
            else if (menuChoice == 2){
                journal.DisplayAll();
            }

            //Load jounal entries into a list from a file for use
            else if (menuChoice == 3){
                Console.WriteLine("Filename: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
                journal.DisplayAll();
            }

            //Save current list buffer to file. Clear buffer.
            else if (menuChoice == 4){
                 Console.WriteLine("Filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

            }

            else {
                Console.WriteLine("What would you like to do? (0-4)");
            }
        }
        
        
        
        
        
        
        
        
        

        //PromptGenerator promptGenerator = new PromptGenerator();

        //string prompt = promptGenerator.GetPrompt();

       // Console.WriteLine($"{DateTime.Today} --- {prompt}");
        
        //string entry = Console.ReadLine();

        // Entry entry1 = new Entry(DateTime.Today, prompt, entry);

        // entry1.Display();

        // journal.AddEntry(entry1);
        //Before this, get user filename
        //journal.SaveToFile("journal.txt");


    }
}