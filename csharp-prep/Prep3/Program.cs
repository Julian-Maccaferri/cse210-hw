using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's the magic number? ");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        Console.WriteLine(number);

        Console.Write("What's your guess? ");
        randomGenerator = new Random();
        int guess = randomGenerator.Next(1, 100);
        Console.WriteLine(guess);

        do
        {
            if (number > guess)
            {
                Console.WriteLine("Higher ");
            }

            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What's your guess? ");
            randomGenerator = new Random();
            guess = randomGenerator.Next(1, 100);
            Console.WriteLine(guess);

        } while (number != guess);
        
        Console.WriteLine("You guessed it!");
    }
}