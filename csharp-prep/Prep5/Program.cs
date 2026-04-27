using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        // username as strings
        // userNumber as interger
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        // use the userNumber to square it.
        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);


        DisplayResult(userName, squaredNumber, birthYear);
    }

    static void DisplayWelcomeMessage()
    {   // First line of code is to welcome the program
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {   // User to enter their name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {   // user to enter their favourite number
        // Use int to convert number to intergers
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static void PromptUserBirthYear(out int birthYear)
    {   // Ask uer to enter year they were born
        // int.Parse to convert the user answer to intergers
        Console.Write($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());

    }

    static int SquareNumber(int number)
    {   // formular to square the user  number or the favourite number
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    // line of code to display all the function you did 
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
    }
}