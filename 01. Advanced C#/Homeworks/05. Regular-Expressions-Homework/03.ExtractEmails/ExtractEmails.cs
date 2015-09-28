using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        MatchCollection emails = Regex.Matches(Console.ReadLine(), @"(?<=\s|^)([^-._\s][\w\.\-]+@[\w-]+\.[\w\.]+)");
        foreach (Match email in emails)
        {
            Console.WriteLine(email.ToString().Trim('.'));
        }
    }
}

