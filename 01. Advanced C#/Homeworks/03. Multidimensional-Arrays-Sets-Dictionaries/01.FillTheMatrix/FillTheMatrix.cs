using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

class FillTheMatrix
{
    static void Main()
    {
        int rowsAndColsSize = int.Parse(Console.ReadLine());
        char pattern = (char)Console.Read();
        int[,] matrix = new int[rowsAndColsSize, rowsAndColsSize];
        int currentNumber = 1;

        if (Char.ToUpper(pattern).Equals('A'))
        {
            ReadingMatrixA(rowsAndColsSize, matrix, currentNumber);
        }

        else if (Char.ToUpper(pattern).Equals('B'))
        {
            ReadingMatrixB(rowsAndColsSize, matrix, currentNumber);
        }

        PrintingMatrix(matrix);

    }

    public static void ReadingMatrixB(int rowsAndColsSize, int[,] matrix, int currentNumber)
    {
        for (int col = 0; col < rowsAndColsSize; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < rowsAndColsSize; row++)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                }
            }

            else
            {
                for (int row = rowsAndColsSize - 1; row >= 0; row--)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                }
            }
        }
    }

    public static void ReadingMatrixA(int rowsAndColsSize, int[,] matrix, int currentNumber)
    {
        for (int col = 0; col < rowsAndColsSize; col++)
        {
            for (int row = 0; row < rowsAndColsSize; row++)
            {
                matrix[row, col] = currentNumber;
                currentNumber++;
            }
        }
    }

    public static void PrintingMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

