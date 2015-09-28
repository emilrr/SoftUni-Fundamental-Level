using System;
using System.Collections.Generic;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = {1, 3, 4, 5, 1, 0, 5};
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbors(numbers, i));
        }
    }

    public static bool IsLargerThanNeighbors(int[] numbers, int i)
    {
        bool larger = false;
        if (i == 0)
        {
            larger = numbers[i + 1] < numbers[i];
        }
        else if (i > 0 && i < numbers.Length - 1)
        {
            larger = numbers[i + 1] < numbers[i] && numbers[i - 1] < numbers[i];
        }
        else
        {
            larger = numbers[i - 1] < numbers[i];
        }
        return larger;
    }
}

