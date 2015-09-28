using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class ReverseNumber
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        var reverse = GetReversedNumber(number);
        Console.WriteLine(reverse);
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

    }

    public static double GetReversedNumber(double number)
    {
        string numbertToString = (number).ToString();
        string reverseString = ReverseText(numbertToString);
        double reverse = double.Parse(reverseString);
        return reverse;
    }

    public static string ReverseText(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
            sb.Append(text[i]);
        return sb.ToString();
    }

    //static double GetReversedNumber(double x)
    //{
    //    char[] n = Convert.ToString(x).ToCharArray();
    //    Array.GetReversedNumber(n);
    //    return Convert.ToDouble(new string(n));
    //}

}

