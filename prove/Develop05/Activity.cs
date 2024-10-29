using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.WriteLine($"This activity will last for {_duration}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}, Goodbay");
    }

    public void ShowSpinner(int seconds)
    {
        for(int i = 0; i < seconds; i++)
        {
            Console.Write("/\b");
            Thread.Sleep(200);
            Console.Write("-\b");
            Thread.Sleep(200);
            Console.Write("\\\b");
            Thread.Sleep(200);
            Console.Write("|\b");
            Thread.Sleep(200);
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
    }
}
