using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = MessageUserName();
        int userNumber = MessageUserNumber();

        int squareNumber = PromptSquareNumber(userNumber);

        DisplayAnswer(userName, squareNumber);            
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!.");
    }

    static string MessageUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string Name = Console.ReadLine();

        return Name;
    }

    static int MessageUserNumber()
        {
        Console.WriteLine("Please enter your favorite number: ");
        int Number = int.Parse(Console.ReadLine());

        return Number;

    }

    static int PromptSquareNumber(int Number)
    {
        int square = Number * Number;

        return square;

    }

    static void DisplayAnswer(string Name, int square)
    {
        Console.WriteLine($"{Name}, the square of your number is: {square}.");
    }
    
    
}
