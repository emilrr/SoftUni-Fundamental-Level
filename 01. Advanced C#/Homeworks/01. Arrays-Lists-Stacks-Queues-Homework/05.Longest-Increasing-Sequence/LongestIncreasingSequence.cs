using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        List<int> items = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToList();
        List<int> temp = new List<int>();
        List<int> longest = new List<int>();

        for (int i = 0, j = i + 1; i < items.Count; i++, j++)
        {
            temp.Add(items[i]);
            if ((j < items.Count) && (items[i] < items[j]))
            {
                continue;
            }

            else
            {
                if (longest.Count < temp.Count)
                {
                    longest.Clear();
                    longest.AddRange(temp);
                    Console.WriteLine(string.Join(" ", temp));
                    temp.Clear();
                }
                else
                {
                    Console.WriteLine(string.Join(" ", temp));
                    temp.Clear();
                }
            }
        }
        Console.WriteLine("Longest: " + string.Join(" ", longest));
    }
}

