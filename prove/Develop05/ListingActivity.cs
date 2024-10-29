using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() : base("Listing Activity", "This activity helps you list positive things.", 30)
    {
        _prompts = new List<string> { 
            "List things you're grateful for.",
            "List things that make you happy.",
            "List people you appreciate."
        };
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        Console.WriteLine("Start listing (type 'done' when finished):");

        string response;
        do
        {
            response = Console.ReadLine();
            if(response.ToLower() != "done")
            {
                userResponses.Add(response);
            }
        } while(response.ToLower() != "done");

        _count = userResponses.Count;
        return userResponses;
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);

        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }

}