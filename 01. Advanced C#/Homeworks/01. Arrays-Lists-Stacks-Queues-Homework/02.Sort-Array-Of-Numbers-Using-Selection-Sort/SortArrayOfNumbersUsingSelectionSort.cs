using System;
using System.Collections.Generic;
using System.Linq;

public class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        List<int> items = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToList();
        SortNumbers(items);
        PrintNumbers(items);
    }

    static void PrintNumbers(List<int> items)
    {
        foreach (var element in items)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }

    static List<int> SortNumbers(List<int> items)
    {
        for (int i = 0; i < items.Count - 1; i++)
        {
            for (int j = 0; j < items.Count; j++)
            {
                if (items[i] < items[j])
                {
                    int oldNumber = items[i];
                    items[i] = items[j];
                    items[j] = oldNumber;
                }
            }
        }
        return items;
    }
}