using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Julian Maccaferri", "Math");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Julian Maccaferri", "Division", "8.5", "9-12");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Bruno Maccaferri", "Poetry", "20 Love Poems");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}