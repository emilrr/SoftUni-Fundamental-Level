using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<List<int>> subsets = new List<List<int>>();
        List<int> numbers = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToList();

        bool found = false;

        int numOfSubsets = 1 << numbers.Count;

        for (int i = 0; i < numOfSubsets; i++)
        {

            List<int> subset = new List<int>();
            int position = numbers.Count - 1;
            int bitmask = i;

            while (bitmask > 0)
            {
                if ((bitmask & 1) == 1)
                {
                    subset.Add(numbers.ElementAt<int>(position));
                }
                bitmask >>= 1;
                position--;
            }

            if ((subset.Sum() == n) && (subset.Count != 0))
            {
                subsets.Add(new List<int>(subset));
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No matching subsets.");
        }

        var sorted = subsets.OrderBy(x => x.Count);

        foreach (var item in sorted)
        {
            Console.WriteLine(" {0} = {1}", string.Join(" + ", item), n);
        }
    }
}