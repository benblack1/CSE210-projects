using System;

class Program
{
    static void Main()
    {
        DisplayWelcomeMessage();

        Console.WriteLine("Please enter your name: ");
        string name = PromptUserName();

        Console.WriteLine("Please provide your favorite number? ");
        int number = PromptUserNumber();

        int squaredNumber = SquareNumber(number);

        DisplayResult(name, squaredNumber);
        
    }
    static void DisplayWelcomeMessage(){
        Console.WriteLine("Welcome to the Program!");

    }
    static string PromptUserName(){
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        string numString = Console.ReadLine();
        int number = int.Parse(numString);
        return number;
    }

    static int SquareNumber(int favoriteNumber){
        int squaredNumber = favoriteNumber*favoriteNumber;
        return squaredNumber;
    }

    static void DisplayResult(string name, int number){
        Console.WriteLine($"{name}, the square of your favorite number is {number}.");
    }

}