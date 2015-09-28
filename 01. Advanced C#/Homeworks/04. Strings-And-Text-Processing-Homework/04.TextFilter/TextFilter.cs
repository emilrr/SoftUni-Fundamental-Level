using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class TextFilter
{
    static void Main()
    {
        string[] wordsArr = Console.ReadLine().Split(',');
        string quote =Console.ReadLine();
        Console.WriteLine();
        quote = ReplaceWordsInText(wordsArr, quote);
        Console.WriteLine(quote);
    }

    public static string ReplaceWordsInText(string[] wordsArr, string quote)
    {
        for (int i = 0; i < wordsArr.Length; i++)
        {
            int lenght = 0;
            lenght = wordsArr[i].Length;
            quote = Regex.Replace(quote, wordsArr[i], new string('*', lenght));
        }
        return quote;
    }
}

