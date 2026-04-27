using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());
        
        while (guess != magicNumber)
        {
            
            Console.Write ("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
           

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine ("Lower");
            }
            else if(magicNumber == guess)
            {
                Console.WriteLine("You guess it.");
                Console.WriteLine("");
                
                
            }   
            else
            {
                Console.WriteLine("Thanks for playing. ");
            }
          
            



        }


    }
}