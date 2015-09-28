using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

class MinMaxAverage
{
    static void Main()
    {
        List<double> items = Console.ReadLine().Split(' ').Select(p => double.Parse(p, System.Globalization.CultureInfo.InvariantCulture)).ToList();
        Console.WriteLine();
        List<double> firstList = new List<double>();
        List<double> secondList = new List<double>();

        foreach (var element in items) // separete elements
        {
            int number = Convert.ToInt32(element);
            double diff = element - number;
            if (diff < 0.00000000000000000001)
            {
                firstList.Add(number);
            }
            else
            {
                secondList.Add(element);
            }
        }

        PrintArray(firstList);
        PrintArray(secondList);
    }

    static void PrintArray(List<double> sheet)
    {
        Console.Write("[ ");
        foreach (var element in sheet)
        {
            Console.Write(element + ", ");
        }
        Console.Write("] - > ");
        Console.Write("min: " + sheet.Min() + ", max: " + sheet.Max() + ", sum: " + sheet.Sum() + ", avg: {0:f2}",sheet.Average());
        Console.WriteLine();
    }
}

