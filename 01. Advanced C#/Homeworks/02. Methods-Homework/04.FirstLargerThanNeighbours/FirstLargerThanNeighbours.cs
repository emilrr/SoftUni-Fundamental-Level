using System;
using System.Collections.Generic;
using System.Linq;

class FirstLargerThanNeighbours
{


    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    public static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
    {
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsLargerThanNeighbors(numbers, i))
            {
                return i;
            }
        }
        return -1;
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


