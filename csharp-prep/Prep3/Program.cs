using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int number = -1;


        while (number != magicNumber)
        {
            Console.WriteLine("Guess the magic number: ");
            number = int.Parse(Console.ReadLine());

            if (magicNumber < number)
            {
                Console.WriteLine("Guess lower");
            }
            else if (magicNumber > number)
            {
                Console.WriteLine("Guess higher");
            }
            else 
            {
                Console.WriteLine("Congratulations you guessed it!");
            }
        }
    //    Console.Write("Guess the magic number: ");
    //    string guessNumber = Console.ReadLine();

    //    int magicNumber = int.Parse(guessNumber);
    //    int number = 25;
        
    //    if (magicNumber == number)
    //        {
    //            Console.WriteLine("You guessed it!!");
    //        }
    //    else
    //    {
    //        while (magicNumber != number)

    //        {
    //            if (magicNumber < number)
    //            {
    //                Console.WriteLine("Guess a higer number");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Guess a lower number");
    //            }

    //            Console.Write("Guess again: ");
    //            guessNumber = Console.ReadLine();
    //            magicNumber = int.Parse(guessNumber);
    //        }
    //        Console.WriteLine("You guessed it!"); 

    //    } 
  

    }
}