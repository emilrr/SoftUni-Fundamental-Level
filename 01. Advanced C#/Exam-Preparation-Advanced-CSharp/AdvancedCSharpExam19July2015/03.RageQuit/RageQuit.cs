namespace _03.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class RageQuit
    {
        private static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = "([\\D]+)(\\d+)";

            Regex rgx = new Regex(pattern);
            MatchCollection matches = Regex.Matches(text, pattern);
            StringBuilder str = new StringBuilder();

            foreach (Match match in matches)
            {
                int repeatNumber = int.Parse(match.Groups[2].Value);
                string word = match.Groups[1].Value.ToUpper();

                for (int i = 0; i < repeatNumber; i++)
                {
                    str.Append(word);
                }
            }

            string allText = str.ToString();
            List<char> list = new List<char>();

            for (int i = 0; i < allText.Length; i++)
            {
                if (!list.Contains(allText[i]))
                {
                    list.Add(allText[i]);
                }
            }

            //int uniqueSymbols = result.ToString().Distinct().Count();

            Console.WriteLine("Unique symbols used: {0}", list.Count);
            Console.WriteLine(allText);
        }
    }
}
