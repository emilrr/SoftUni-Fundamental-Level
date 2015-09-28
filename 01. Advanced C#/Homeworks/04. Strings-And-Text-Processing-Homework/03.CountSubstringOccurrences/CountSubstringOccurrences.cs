using System;
using System.Collections.Generic;
using System.Linq;


class CountSubstringOccurrences
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string word = Console.ReadLine();
        var count = FindWordInText(text, word);
        Console.WriteLine(count);
    }

    public static int FindWordInText(string text, string word)
    {
        int index = text.IndexOf(word, StringComparison.CurrentCultureIgnoreCase);
        int count = 0;
        while (index != -1)
        {
            count ++;
            index = text.IndexOf(word, index + 1);
        }
        return count;
    }
}

