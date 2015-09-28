using System;
using System.Collections.Generic;
using System.Text;

class NumberCalculations
{
    static void Main()
    {
        double[] array = { 1.5, 22.4, 5.55, 2.0, 46.3, 1111.4, 245.00};
        double Max = GetMaximum(array);
        double Min = GetMinimum(array);
        double Avg = GetAverage(array);
        double Sum = GetSum(array);
        double Product = GetProduct(array);
        Console.WriteLine("Min = " + Min);
        Console.WriteLine("Max = " + Max);
        Console.WriteLine("Average = " + Avg);
        Console.WriteLine("Sum = " + Sum);
        Console.WriteLine("Product = " + Product);

    }

    public static double GetAverage(double[] array)
    {
        int lenght = array.Length;
        double average = GetSum(array) / lenght;
        return average;
    }

    public static double GetSum(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            double number = array[i];
            sum += number;
        }
        return sum;
    }
    public static double GetProduct(double[] array)
    {
        double product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            double number = array[i];
            product *= number;
        }
        return product;
    }
    public static double GetMaximum(double[] array)
    {
        double maximum = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                maximum = array[i];
            }
            else
            {
                maximum = array[i + 1];
            }
        }
        return maximum;
    }
    public static double GetMinimum(double[] array)
    {
        double number = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                number = array[i];
                array[i] = array[i + 1];
                array[i + 1] = number;
            }
        }
        return number;
    }
}

