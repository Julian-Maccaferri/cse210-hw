using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(30, 3.0));
        activities.Add(new Cycling(45, 12.0));
        activities.Add(new Swimming(30, 20));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}