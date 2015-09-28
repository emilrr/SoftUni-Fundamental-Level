using System;

namespace _03.ExtractHyperlinks
{
    using System.Text;
    using System.Text.RegularExpressions;

    internal class ExtractHyperlinks
    {
        private static void Main()
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string text = Console.ReadLine();

                if (text == "END")
                {
                    break;
                }

                sb.Append(text);
            }

            var textAll = sb.ToString();
            const string ArrowPattern = @"(<\s*a\s[^>]*?\bhref\s*=\s*)('(?<url>[^']*)'|""(?<url>[^""]*)""|(?<url>\S*))";

            Match match = Regex.Match(textAll, ArrowPattern);
            while (match.Success)
            {
                string url = match.Groups["url"].Value;
                Console.WriteLine("{0}", url);
                match = match.NextMatch();
            }
        }
    }
}
