using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and hi Prep1 World!");

        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Console.Write("What is your last name?: ");
        string lastName = Console.ReadLine();
        Console.Write("\n");
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}. ");
    }
}