using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);
        string letter = grade.ToString();
        
        //if (grade >= 90)
        //{
        //   Console.WriteLine("Your grade is A");
        //}
        //else if (grade >= 80)
        //{
        //    Console.WriteLine("Your grade is B");
        //}
        //else if (grade >= 70)
        //{
        //    Console.WriteLine("Your grade is C");
        //}
        //else if (grade >= 60)
        //{
        //    Console.WriteLine("Your grade is D");
        //}
        //else if (grade < 60)
        //{
        //    Console.WriteLine("Your grade is F");
        //}

        //if (grade >= 70)
        //{
        //    Console.WriteLine("Congratulations you passed the course!!.");
        //}
        //else if (grade < 70)
        //{
        //    Console.WriteLine("You can do it better next time!!.");
        //}


        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";;
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";;
        }
        else (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed the course!!.");
        }
        else if (grade < 70)
        {
            Console.WriteLine("You can do it better next time!!.");
        }

    }
}