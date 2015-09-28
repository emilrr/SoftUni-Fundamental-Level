using System;
using System.Collections.Generic;
public class Subsets
{
    static string[] words = { "море", "бира", "пари", "кеф" };
    static void Main()
    {
        Queue<List<int>> subsetsQueue = new Queue<List<int>>();
        List<int> emptySet = new List<int>();
        subsetsQueue.Enqueue(emptySet);
        while (subsetsQueue.Count > 0)
        {
            List<int> subset = subsetsQueue.Dequeue();
            Print(subset);
            int start = -1;
            if (subset.Count > 0)
            {
                start = subset[subset.Count - 1];
            }
            for (int i = start + 1; i < words.Length; i++)
            {
                List<int> newSubset = new List<int>();
                newSubset.AddRange(subset);
                newSubset.Add(i);
                subsetsQueue.Enqueue(newSubset);
            }
        }
    }
    static void Print(List<int> subset)
    {
        Console.Write("[ ");
        for (int i = 0; i < subset.Count; i++)
        {
            int index = subset[i];
            Console.Write("{0} ", words[index]);
        }
        Console.WriteLine("]");
    }
}