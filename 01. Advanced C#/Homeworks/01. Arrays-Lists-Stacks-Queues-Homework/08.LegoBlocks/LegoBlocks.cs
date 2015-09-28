using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LegoBlocks
{
    static void Main()
    {
        int numberRows = int.Parse(Console.ReadLine());
        List<List<char>> matrixFirst = new List<List<char>>();
        List<List<char>> matrixSecond = new List<List<char>>();

        FillMatrix(numberRows, matrixFirst);
        FillMatrix(numberRows, matrixSecond);

        MergeMatrices(numberRows, matrixFirst, matrixSecond);
        bool isRectangle = false;

        for (int i = 1; i < numberRows; i++)
        {
            int lenght = matrixFirst[0].Count;

            if (matrixFirst[i].Count == lenght)
            {
                isRectangle = true;
            }
            else
            {
                isRectangle = false;
                break;
            }
        }

        if (isRectangle)
        {
            PrintingMatrix(numberRows, matrixFirst);
        }

        else
        {
            int counter = 0;

            for (int row = 0; row < numberRows; row++)
            {
                for (int col = 0; col < matrixFirst[row].Count; col++)
                {
                    counter++;
                }
            }

            Console.WriteLine("The total number of cells is: {0}", counter);
        }
    }

    private static void FillMatrix(int numberRows, List<List<char>> matrix)
    {
        for (int i = 0; i < numberRows; i++)
        {
            string[] lineArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string line = string.Join("", lineArray);

            matrix.Add(line.ToList());
        }
    }

    private static void MergeMatrices(int numberRows, List<List<char>> matrixFirst, List<List<char>> matrixSecond)
    {
        for (int i = 0; i < numberRows; i++)
        {
            matrixSecond[i].Reverse();
            matrixFirst[i].AddRange(matrixSecond[i]);
        }
    }

    private static void PrintingMatrix(int numberRows, List<List<char>> matrix)
    {
        for (int row = 0; row < numberRows; row++)
        {
            Console.Write("[");

            for (int col = 0; col < matrix[row].Count; col++)
            {
                if (col == matrix[row].Count - 1)
                {
                    Console.Write(string.Format("{0}]", matrix[row][col]));
                }

                else
                {
                    Console.Write(string.Format("{0}, ", matrix[row][col]));
                }
            }

            Console.WriteLine();
        }
    }
}