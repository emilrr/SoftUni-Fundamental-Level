using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringMatrixRotation
{
    using System.Text.RegularExpressions;

    public class StringMatrixRotation
    {
        static void Main()
        {
            int maxLenght = Int32.MinValue;

            List<string> matrix = new List<string>();

            string firstLine = Console.ReadLine();

            string findDegrees = Regex.Match(firstLine, @"\d+").Value;

            int degrees = int.Parse(findDegrees);

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Length > maxLenght)
                {
                    maxLenght = input.Length;
                }

                if (input == "END")
                {
                    break;
                }

                matrix.Add(input);
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                if (matrix[i].Length < maxLenght)
                {
                    matrix[i] = matrix[i] + new string(' ', maxLenght - matrix[i].Length);
                }

            }

            char[,] matrixRotation90 = new char[maxLenght, matrix.Count];

            for (int row = 0; row < maxLenght; row++)
            {
                for (int col = 0; col < matrix.Count; col++)
                {
                    matrixRotation90[row, col] = matrix[col][row];
                }
            }

            if (degrees == 90 || degrees % 360 == 90)
            {
                for (int row = 0; row < matrixRotation90.GetLength(0); row++)
                {
                    for (int col = matrixRotation90.GetLength(1) - 1; col >= 0; col--)
                    {
                        Console.Write("{0}", matrixRotation90[row, col]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degrees == 180 || degrees % 360 == 180)
            {
                for (int row = matrix.Count - 1; row >= 0; row--)
                {
                    for (int col = matrix[row].Length - 1; col >= 0; col--)
                    {
                        Console.Write("{0}", matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degrees == 270 || degrees % 360 == 270)
            {
                for (int row = matrixRotation90.GetLength(0) - 1; row >= 0; row--)
                {
                    for (int col = 0; col < matrixRotation90.GetLength(1); col++)
                    {
                        Console.Write("{0}", matrixRotation90[row, col]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degrees == 0 || degrees % 360 == 0)
            {
                foreach (var matrix360 in matrix)
                {
                    Console.WriteLine(matrix360);
                }
            }
        }
    }
}
