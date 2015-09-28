using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PythagoreanNumbers
{
    public class PythagoreanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numberArray = new int[n];
            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberArray.Length; i++)
            {
                foreach (var second in numberArray)
                {
                    foreach (var third in numberArray)
                    {
                        int a = numberArray[i];
                        int b = second;
                        int c = third;

                        if (a <= b && b <= c && (a * a + b * b) == c * c)
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                            isFound = true;
                        }
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}