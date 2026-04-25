using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {   // Ask the user for percentage
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        // convert answer to intergers by using parse.
        int percent = int.Parse(answer);

        string score = "";
        // Using if or else or else if to form a set of conversation.
        if (percent >= 90)
        {
            score = "A";
            if (percent >= 97)
            {
                score = "A";
            }
            else
            {
                score = "A-";
            }
        }
        else if (percent >= 80)
        {
            score = "B";

            if (percent >= 87)
            {
                score = "B+";
            }
            else
            {
                score = "B-";
            }
        }
        else if (percent >= 70)
        {  
            score = "C";

            if (percent >= 77)
            {
                score = "C+";
            }
            else
            {
                score = "C-";
            }  
        }

        else if (percent >= 60)
        {
          score = "D";

          if (percent >= 67)
            {
                score = "D+";
            }
            else
            {
                score = "D-";
            }
        }
        else
        { 
            score = "F";
        }

        Console.WriteLine($"Your grade is: {score
        }");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulation You Pass");
        }
        else
        {
            Console.WriteLine("Sorry You Fail, Try again.");
        }





    
    }
}