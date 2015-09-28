using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Palindromes
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] separators = new char[] { ',', ' ', '!', '?', '.' };
        string[] textSep = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        List<string> listSort = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < textSep.Length; i++)
        {
            sb.Append(textSep[i]);
            FillList(sb, listSort);
        }
        listSort.Sort();
        for (int i = 0; i < listSort.Count; i++) // Loop with for.
        {
            Console.Write("{0}, ", listSort[i]);
        }
        Console.WriteLine();
        
    }

    public static void FillList(StringBuilder sb, List<string> listSort)
    {
        for (int k = 0; k <= sb.Length/2; k++)
        {
            if (sb.Length == 2)
            {
                if (sb[k] == sb[k + 1])
                {
                    listSort.Add(sb.ToString());
                }
            }

            else if (sb[k] == sb[sb.Length - k - 1])
            {
                listSort.Add(sb.ToString());
            }

            sb.Clear();
        }
    }
}

