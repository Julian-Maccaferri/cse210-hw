using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };

    /*public PromptGenerator()
    {
        string prompt1 = "Who was the most interesting person I interacted with today?";
        string prompt2 = "What was the best part of my day?";
        string prompt3 = "How did I see the hand of the Lord in my life today?";
        string promtp4 = "What was the strongest emotion I felt today?";
        string prompt5 = "If I had one thing I could do over today, what would it be?";

        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(promtp4);
        _prompts.Add(prompt5);
    }*/
    public string ShowRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);
        return _prompts[number];
    }
}



