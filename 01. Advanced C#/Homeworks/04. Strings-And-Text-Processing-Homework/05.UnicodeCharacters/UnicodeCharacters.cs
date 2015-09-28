using System;
using System.Collections.Generic;
using System.Linq;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] values = input.ToCharArray();
        foreach (char letter in values)
        {
            int value = Convert.ToInt32(letter);
            string hexOutput = String.Format("{0:x4}", value);
            Console.Write("\\{0}", hexOutput);
        }
        Console.WriteLine();
    }
}

