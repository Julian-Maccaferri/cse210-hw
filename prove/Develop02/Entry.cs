using System;
using System.Collections.Generic;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public string DisplayEntry()
    {
        return $"Date: {_date} - Prompt: {_promptText}"; 
    }

    public string DisplayResponse()
    {
        return $"{_entryText}";
    }  
}

