using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

class CountSymbols
{
    static void Main()
    {
        Console.WriteLine("Please enter a text with letters to count: ");
        string text = Console.ReadLine();

        SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (!symbols.ContainsKey(text[i]))
            {
                symbols.Add(text[i], text.Count(x => x == text[i]));
            }
        }

        foreach (var pair in symbols)
        {
            Console.WriteLine("{0}: {1} time/s",
                pair.Key, pair.Value);
        }
    }
}

