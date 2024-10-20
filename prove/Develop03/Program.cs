using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, " +
                    "that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, text);

        while(true)
        {
            scripture.GetDisplayScripture();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden");
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string choise = Console.ReadLine();

            if (choise == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}