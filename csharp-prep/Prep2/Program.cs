using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";
        Console.Write("Enter Grade percentage: ");
        string percentage = Console.ReadLine();

        int number = int.Parse(percentage);
        if (90<=number && number<=100){
            letterGrade = "A";
        }
        else if (number >= 80 && number< 90){
            letterGrade = "B";
        }
        else if (number>=70 && 80> number){
            letterGrade = "C";
        }
        else if (number >= 60 && 70 > number){
            letterGrade = "D";
        }
        else if (number < 60){
            letterGrade = "F";
        }
        else {
            Console.WriteLine("Enter an accurate percentage");
        }

        Console.WriteLine($"Your final grade is {letterGrade}");
        if (number <70){
            Console.WriteLine("Sorry. You failed the class. Better luck next time.");
        }
        else if (number>=70){
            Console.WriteLine("You have passed the class. Well done.");
        }

    }
}