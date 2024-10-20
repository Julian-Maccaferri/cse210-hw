using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach(string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);

            _words[index].Hide();
        }
    }

    public void GetDisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetDisplayReference());
        foreach(Word word in _words)
        {
            Console.Write(word.GetDisplayText()+ " ");
        }
        Console.WriteLine();
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
} 