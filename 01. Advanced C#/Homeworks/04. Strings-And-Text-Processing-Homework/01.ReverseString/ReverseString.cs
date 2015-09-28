using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string text = Console.ReadLine();
        string reversed = ReverseText(text);
        Console.WriteLine(reversed);

    }

    public static string ReverseText(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length - 1; i >= 0 ; i--)
        {
            sb.Append(text[i]);
            
        }
        return sb.ToString();
    }
}

