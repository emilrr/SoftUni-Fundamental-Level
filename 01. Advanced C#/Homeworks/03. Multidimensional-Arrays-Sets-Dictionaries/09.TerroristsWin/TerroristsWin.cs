using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.TerroristsWin
{
    class TerroristsWin
    {
        static void Main()
        {
            string text = Console.ReadLine();

            int firstIndex = text.IndexOf('|');            
            int sumASCII = 0;
            int spread = 0;

            while(firstIndex != -1)
            {
                int secondIndex = text.IndexOf('|', firstIndex + 1); 

                int bombLength = secondIndex - (firstIndex + 1);
                string bomb = text.Substring(firstIndex + 1, bombLength);
                sumASCII = bomb.ToCharArray().Select(c => (int)c).Sum();
                spread = sumASCII % 10;

                int startIndex = firstIndex - spread;
                int endIndex = secondIndex + spread;
                
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex > text.Length)
                {
                    endIndex = text.Length - 1;
                }
                

                int destroyedArea = endIndex - startIndex + 1;

                text = text.Remove(startIndex, destroyedArea).Insert(startIndex, new string('.', destroyedArea));
                firstIndex = text.IndexOf('|', secondIndex + 1);
            }

            Console.WriteLine(text);
        }
    }
}
