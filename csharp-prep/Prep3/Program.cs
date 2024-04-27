using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,100);
        bool wrongAnswer = true;
        

        while (wrongAnswer){
            Console.Write("Please guess a number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            if (number == randomNumber){
                Console.WriteLine("Yay! You guessed it!");
                wrongAnswer = false;
            }
            else if (number > randomNumber){
                Console.WriteLine("Guess lower");
            }
            else if (number < randomNumber){
                Console.WriteLine("Guess higher");
            }
            
        }
    }
}