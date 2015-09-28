using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Parachute
{
    class Parachute
    {
        static void Main()
        {
            List<char[]> matrix = new List<char[]>();

            FillMatrix(matrix);

            int previousCol = 0;

            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {

                    if (matrix[row][col] == 'o')
                    {
                        previousCol = col;
                        break;
                    }
                    else if (matrix[row][col] == '>')
                    {
                        previousCol++;
                    }
                    else if (matrix[row][col] == '<')
                    {
                        previousCol--;
                    }

                }

                for (int cols = 0; cols < matrix[row].Length; cols++)
                {
                    if ((matrix[row][cols] == '/' || matrix[row][cols] == '\\' || matrix[row][cols] == '|') && cols == previousCol)
                    {
                        Console.WriteLine("Got smacked on the rock like a dog!");
                        Console.WriteLine("{0} {1}", row, cols);
                        break;
                    }
                    else if (matrix[row][cols] == '_' && cols == previousCol)
                    {
                        Console.WriteLine("Landed on the ground like a boss!");
                        Console.WriteLine("{0} {1}", row, cols);
                        break;
                    }
                    else if (matrix[row][cols] == '~' && cols == previousCol)
                    {
                        Console.WriteLine("Drowned in the water like a cat!");
                        Console.WriteLine("{0} {1}", row, cols);
                        break;
                    }
                }
            }


        }
        private static void FillMatrix(List<char[]> matrix)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                matrix.Add(line.ToCharArray());
            }
        }
    }
}
