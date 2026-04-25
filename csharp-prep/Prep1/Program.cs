using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their names.
        Console.Write("What is your first name? ");
        // Let the user answer the question
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine (); 
        // give a blank line between
        Console.WriteLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}