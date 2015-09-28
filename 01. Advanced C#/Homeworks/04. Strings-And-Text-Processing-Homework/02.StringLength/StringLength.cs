using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class StringLength
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        PrintPartOfText(text);
    }

    private static void PrintPartOfText(string text)
    {
        int lenght = text.Length;
        if (lenght < 20)
        {
            int n = 20 - lenght;
            Console.WriteLine("{0}{1}", text, new string('*', n));
        }
        else
        {
            Console.WriteLine(text.Substring(0, 20));
        }
    }
}

