using System;
using System.Collections.Generic;
using System.Linq;

public class SortArrayOfNumbers
{
    static void Main()
    {
        List<int> items = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToList();
        items.Sort();

        foreach (var  element in items)
        {
            Console.Write(element + " ");
        }
    }
}