using System;
using System.Collections.Generic;
using System.Linq;

class SequencesОfEqualStrings
{
    static void Main()
    {
        List<string> items = Console.ReadLine().Split(' ').ToList();
        int lenght = items.Count;

        if (lenght == 1)
        {
            foreach (var element in items)
            {
                Console.WriteLine(element);
            }
        }
        else
        {
            for (int i = 0; i < lenght - 1; i++)
            {
                for (int j = i + 1; j < lenght; j++)
                {
                    bool equals = items[i].Equals(items[j]);
                    if (equals == false)
                    {
                        Console.WriteLine(items[i]);

                        if (j == lenght - 1)
                        {
                            Console.WriteLine(items[j]);
                        }

                        break;
                    }
                    else
                    {
                        Console.Write("{0} ", items[i]);
                        if (j == lenght - 1)
                        {
                            Console.WriteLine(items[j]);
                        }

                        i = j;
                    }

                }

            }
        }

    }
}

