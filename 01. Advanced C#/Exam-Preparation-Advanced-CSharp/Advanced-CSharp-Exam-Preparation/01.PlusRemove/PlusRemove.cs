using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PlusRemove
{
    public class PlusRemove
    {
        static void Main()
        {
            List<char[]> matrix = new List<char[]>();

            FillMatrix(matrix);

            char currentValue = '\0';

            HashSet<KeyValuePair<int, int>> coordinatesSet = new HashSet<KeyValuePair<int, int>>();

            for (int row = 1; row < matrix.Count - 1; row++)
            {
                for (int col = 1; col < matrix[row].Length - 1; col++)
                {
                    currentValue = char.ToLower(matrix[row][col]);

                    if (col < matrix[row - 1].Count() && col < matrix[row + 1].Count()
                        && currentValue.Equals(char.ToLower(matrix[row][col - 1]))
                        && currentValue.Equals(char.ToLower(matrix[row][col + 1]))
                        && currentValue.Equals(char.ToLower(matrix[row - 1][col]))
                        && currentValue.Equals(char.ToLower(matrix[row + 1][col])))
                    {
                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row - 1, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row + 1, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col - 1));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col + 1));
                    }
                }
            }

            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    KeyValuePair<int, int> currentKeyValuePair = new KeyValuePair<int, int>(row, col);

                    if (!coordinatesSet.Contains(currentKeyValuePair))
                    {
                        Console.Write(matrix[row][col]);
                    }
                }

                Console.WriteLine();
            }
        }

        private static void FillMatrix(List<char[]> matrix)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                matrix.Add(input.ToCharArray());
            }
        }
    }
}
