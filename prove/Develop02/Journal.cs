using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach(Entry entry in Entries)
        {
            Console.WriteLine(entry.DisplayEntry());
            Console.WriteLine(entry.DisplayResponse());
        }
    }

    public void SaveJournalFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            string[] parts = line.Split('|');
            if(parts.Length == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string userResponse = parts[2];
                Entries.Add(new Entry(date, prompt, userResponse));
            }
        }
    }
}
