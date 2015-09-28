using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.TheNumbers
{
    using System.Text.RegularExpressions;

    class TheNumbers
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string numberPattern = @"([\d](^\w\.)?\d*)";

            MatchCollection machesNumber = Regex.Matches(text, numberPattern);

            StringBuilder finalResult = new StringBuilder();
            StringBuilder textString = new StringBuilder();

            for (int i = 0; i < machesNumber.Count; i++)
            {
                string telephone = machesNumber[i].Groups[1].ToString();
                if (telephone.Length < 4)
                {
                    string reversedFirst = ReverseString(telephone);
                    int lenghtNumber = 4 - telephone.Length;
                    finalResult.Append('0', lenghtNumber);
                    finalResult.Append(machesNumber[i].Groups[1]);

                    int number = Convert.ToInt32(finalResult.ToString());
                    string hexValue = String.Format("0x{0:X4}", number);

                    textString.Append(hexValue);
                    textString.Append('-');
                    finalResult.Clear();

                }
                else
                {
                    int number = Convert.ToInt32(telephone);
                    string hexValue = String.Format("0x{0:X4}", number);
                    textString.Append(hexValue);
                    textString.Append('-');
                }

            }
            Console.WriteLine(textString.ToString().TrimEnd('-'));


        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }
}
