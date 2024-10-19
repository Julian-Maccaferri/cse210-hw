using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the journal programm!");
        
        List <string> options = new List<string>
        {
            "Please select one of the following options:",
            "1. Write",
            "2. Display",
            "3. Save",
            "4. Load",
            "5. Quit",
            "What would you like to do?"
        };

        string choiceOption = "";

        do
        {
            Console.WriteLine("");
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            choiceOption = Console.ReadLine();

            if (choiceOption == "1")
            {
                string prompt = promptGenerator.ShowRandomPrompt();
                Console.WriteLine(prompt);
                string userResponse = Console.ReadLine();
                string date = DateTime.Now.ToString();

                Entry newEntry = new Entry(date, prompt, userResponse);
                journal.AddEntry(newEntry);
            }
            else if (choiceOption == "2")
            {
                journal.DisplayJournal();
            }
            else if (choiceOption == "3")
            {
                Console.Write("Save filename: ");
                string filename = Console.ReadLine();
                journal.SaveJournalFile(filename);
            }
            else if (choiceOption == "4")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();
                journal.LoadFile(filename);
            }
            else if (choiceOption == "5")
            {
                Console.WriteLine("Thank you!");
            }
            else
            {
                Console.WriteLine("Invalid input, try again!");
            }
        } while (choiceOption != "5");
    }
}