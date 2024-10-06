using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");

        int choiseNumber = -1;
        while (choiseNumber != 0)
        {
            Console.Write("Enter number: ");
            string userChoise = Console.ReadLine();
            choiseNumber = int.Parse(userChoise);

            if (choiseNumber != 0)
            {
                numbers.Add(choiseNumber);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is: {total}");

        float avg = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
            
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");
    }
}