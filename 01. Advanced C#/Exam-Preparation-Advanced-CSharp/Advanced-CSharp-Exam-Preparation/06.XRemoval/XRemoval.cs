using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.XRemoval
{
    class XRemoval
    {
        static void Main()
        {
            List<char[]> matrix = new List<char[]>();

            FillMatrix(matrix);

            char currentValue = '\0';

            HashSet<KeyValuePair<int, int>> coordinatesSet = new HashSet<KeyValuePair<int, int>>();

            for (int row = 1; row < matrix.Count - 1; row++)
            {
                for (int col = 1; col < matrix[row].Length; col++)
                {
                    currentValue = Char.ToLower(matrix[row][col]);

                    if (col < matrix[row - 1].Count() - 1 && col < matrix[row + 1].Count() - 1
                        && currentValue.Equals(char.ToLower(matrix[row - 1][col - 1])) && currentValue.Equals(char.ToLower(matrix[row - 1][col + 1]))
                        && currentValue.Equals(char.ToLower(matrix[row + 1][col - 1])) && currentValue.Equals(char.ToLower(matrix[row + 1][col + 1])))
                    {

                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row - 1, col - 1));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row - 1, col + 1));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row + 1, col - 1));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row + 1, col + 1));

                    }

                }
            }

            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    KeyValuePair<int, int> curKeyValuePair = new KeyValuePair<int, int>(row, col);
                    if (!coordinatesSet.Contains(curKeyValuePair))
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
