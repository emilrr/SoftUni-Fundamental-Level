using System;
using System.Collections.Generic;
using System.Linq;

class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        var output = GetMax(firstNumber, secondNumber);
        Console.WriteLine(output);

    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int max = firstNumber;
        if (secondNumber > firstNumber)
        {
            max = secondNumber;
        }
        return max;
    }
}

