using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        
        // Declare all the variables
        List<int> numbers= new List<int>();
        bool notFinished = true;
        int total = 0;
        int totalCount = 0;
        int largestToDate = 0;
        Console.Write("Enter a number. Hit 0 when you are finished.");

        //I wanted to do all the counting and calculations in the while loop and
        //not pull in a foreach loop just for the heck of it, to 
        //prove to myself that I could.  
        while (notFinished){
            string userInput = Console.ReadLine();
            int nextItem = int.Parse(userInput);
            if (nextItem != 0){
                numbers.Add(nextItem);
                total += nextItem;
                totalCount ++;
                if (nextItem > largestToDate){
                    largestToDate = nextItem;
                }
            }
            else{
                notFinished = false;
            }
        }
        
        float average = total/totalCount;
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number was {largestToDate}");
    }
}