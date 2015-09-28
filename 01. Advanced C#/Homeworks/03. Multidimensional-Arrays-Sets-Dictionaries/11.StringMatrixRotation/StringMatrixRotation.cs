using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main()
        {
            string rotate = Console.ReadLine();

            string[] integer = rotate.Split('(');

            integer[1] = integer[1].Remove(integer[1].Length - 1, 1);

            int degrees = int.Parse(integer[1]);

            int longestWord = 0;
            List<string> matrix = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (longestWord < line.Length)
                {
                    longestWord = line.Length;
                }

                if (line == "END")
                {
                    break;
                }
                matrix.Add(line);
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                if (matrix[i].Length < longestWord)
                {
                    matrix[i] = matrix[i] + new string(' ', longestWord - matrix[i].Length);
                }
            }

            char[,] matrixRotation90 = new char[longestWord, matrix.Count];

            for (int row = 0; row < longestWord; row++)
            {
                for (int col = 0; col < matrix.Count; col++)
                {
                    matrixRotation90[row, col] = matrix[col][row];
                }
            }


            if (degrees == 180 || degrees % 360 == 180)
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

            else if (degrees == 90 || degrees % 360 == 90)
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
                foreach (var degrees360 in matrix)
                {
                    Console.WriteLine(degrees360);
                }
            }

        }



    }
}
