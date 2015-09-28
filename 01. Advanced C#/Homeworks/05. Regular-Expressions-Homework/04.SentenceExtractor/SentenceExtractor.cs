using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string keyWord = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = string.Format(@"(?<=\s|^)(.*?\b{0}\b.*?(?=\!|\.|\?)[?.!])", keyWord);
        Regex rgx = new Regex(pattern);
        Match match = rgx.Match(text);

        if (match.Groups.Count == 0)
        {
            Console.WriteLine("No matches found.");
        }
        else
        {
            while (match != Match.Empty)
            {
                Console.WriteLine(match.Value);
                match = match.NextMatch();
            }
        }
    }
}

