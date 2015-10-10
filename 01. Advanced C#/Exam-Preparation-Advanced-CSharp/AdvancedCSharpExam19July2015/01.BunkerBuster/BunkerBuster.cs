namespace _01.BunkerBuster
{
    using System;
    using System.Linq;

    internal class BunkerBuster
    {
        private static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            int[,] matrix = new int[rows, cols];
            int destroyed;

            FillMatrix(rows, cols, matrix);

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("cease fire!"))
                {
                    break;
                }

                string[] dimensionsBomb = input.Split(' ');
                int bombRow = int.Parse(dimensionsBomb[0]);
                int bombCol = int.Parse(dimensionsBomb[1]);
                int fullPower = Convert.ToInt32(char.Parse(dimensionsBomb[2]));
                int halfPower = (int)Math.Ceiling(fullPower / 2.0);

                int startRow = Math.Max(0, bombRow - 1);
                int endRow = Math.Min(bombRow + 1, rows - 1);
                int startCol = Math.Max(0, bombCol - 1);
                int endCol = Math.Min(bombCol + 1, cols - 1);

                for (int row = startRow; row <= endRow; row++)
                {
                    for (int col = startCol; col <= endCol; col++)
                    {
                        if (row == bombRow && col == bombCol)
                        {
                            matrix[row, col] -= fullPower;
                        }
                        else
                        {
                            matrix[row, col] -= halfPower;
                        }
                    }
                }
            }

            destroyed = GetDestroyedBunkersCount(matrix);
           // double damage = (double)(destroyed * 100) / (rows * cols);
           // damage = Math.Round(damage, 1);
            double totalDamage = (double)destroyed / matrix.Length;

            Console.WriteLine("Destroyed bunkers: {0}", destroyed);
            Console.WriteLine("Damage done: {0:P1}", totalDamage);
        }

        private static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine()
                    .TrimEnd()
                    .Split(' ')
                    .Select(x => int.Parse(x))
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }

        private static int GetDestroyedBunkersCount(int[,] matrix)
        {
            int counterDestroyed = 0;

            foreach (var number in matrix)
            {
                if (number <= 0)
                {
                    counterDestroyed++;
                }
            }

            return counterDestroyed;
        }
    }
}
