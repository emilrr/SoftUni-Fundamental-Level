namespace _03.PlusRemoveReformatted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PlusRemoveReformatted
    {
        internal static void Main()
        {
            List<char[]> matrix = new List<char[]>();
            char currentValue = '\0';

            FillMatrix(matrix);

            HashSet<KeyValuePair<int, int>> coordinatesSet = new HashSet<KeyValuePair<int, int>>();

            for (int row = 1; row < matrix.Count - 1; row++)
            {
                for (int col = 1; col < matrix[row].Count() - 1; col++)
                {
                    currentValue = char.ToLower(matrix[row][col]);

                    if (col < matrix[row - 1].Count()
                        && col < matrix[row + 1].Count()
                        && currentValue.Equals(char.ToLower(matrix[row - 1][col]))
                        && currentValue.Equals(char.ToLower(matrix[row][col - 1]))
                        && currentValue.Equals(char.ToLower(matrix[row][col + 1]))
                        && currentValue.Equals(char.ToLower(matrix[row + 1][col])))
                    {
                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row - 1, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row + 1, col));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col + 1));
                        coordinatesSet.Add(new KeyValuePair<int, int>(row, col - 1));
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

        private static bool IsCellIsideMatrix(int row, int col, List<char[]> matrix)
        {
            bool isRowInsideMatrix = 0 <= row && row < matrix.Count;

            if (!isRowInsideMatrix)
            {
                return false;
            }

            bool isColInRange = 0 <= col && col < matrix[row].Length;

            return isColInRange;
        }
    }
}