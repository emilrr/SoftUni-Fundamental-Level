using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StuckNumbers
{
    public class StuckNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string numbers = Console.ReadLine().TrimEnd();
            string[] numberArray = numbers.Split(' ');
            bool isFound = false;


            for (int i = 0; i < numberArray.Length; i++)
            {
                foreach (var second in numberArray)
                {
                    foreach (var third in numberArray)
                    {
                        foreach (var fourth in numberArray)
                        {
                            string a = numberArray[i].ToString();
                            string b = second.ToString();
                            string c = third.ToString();
                            string d = fourth.ToString();
                            string firstSubstring = a + b;
                            string secondSubstring = c + d;

                            if (!(a.Equals(b)) && !(a.Equals(c)) && !(a.Equals(d)) &&
                                !(b.Equals(c)) && !(b.Equals(d)) && !(c.Equals(d))
                                    && firstSubstring.Equals(secondSubstring))
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                                isFound = true;
                            }
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

