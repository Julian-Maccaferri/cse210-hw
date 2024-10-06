using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade?");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter = "No grade";

        if (grade >= 90)
        {
            letter = "A";            
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        if (grade < 70)
        {
            Console.WriteLine(letter);
            Console.WriteLine("Better luck next time!");
        }

        else
        {
            Console.WriteLine(letter);
            Console.WriteLine("Congratulations!");
        }     

    }
}