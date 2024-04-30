using System;
using System.Collections.Generic;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>();
        Console.Write("Please enter a list of numbers, tipe 0 when finished ");
        int userNum = -1;

        while (userNum != 0)
        {
            Console.WriteLine("Enter your list of numbers, type 0 when finished: ");

            string userAnswer = Console.ReadLine();
            userNum = int.Parse(userAnswer);

            if (userNum != 0);
            {
                num.Add(userNum);
            }

        }    

        int sum = 0;
        foreach (int number in num)
        {
            sum += number;
        }

        Console.WriteLine("The sum is: " + sum);

        float average = ((float)sum) / num.Count;
        Console.WriteLine("Te average of the list is: " + average);

        int maximum = num[0];

        foreach (int number in num)
        {
            if (number > maximum)
            {
                maximum = number;
            }

        }
        Console.WriteLine($"The maximum number is: {maximum}");
        
             


    }
}
