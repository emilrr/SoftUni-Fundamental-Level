using System;
using System.Collections.Generic;
using System.Linq;

class LastDigitOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int lastIndex = number % 10;
        Console.WriteLine(GetLastDigitAsWord(lastIndex));


    }
    static string GetLastDigitAsWord(int index)
    {
        string lastIndex;
        switch (index)
        {
            case  0:
                lastIndex = "zero";
                break;
            case 1:
                lastIndex = "one";
                break;
            case 2:
                lastIndex = "two";
                break;
            case 3:
                lastIndex = "three";
                break;
            case 4:
                lastIndex = "four";
                break;
            case 5:
                lastIndex = "five";
                break;
            case 6:
                lastIndex = "six";
                break; 
            case 7:
                lastIndex = "seven";
                break;
            case 8:
                lastIndex = "eight";
                break;
            case 9:
                lastIndex = "nine";
                break;
            default:
                return null;
        }
        return lastIndex;
    }
}

