
namespace MatrixMultiply
{
    using System;

    internal class MatrixMultiply
    {
        public static void Main()
        {
            var matrixA = new double[,]
                {
                    { 1, 3 }, 
                    { 5, 7 }
                };
            var matrixB = new double[,]
                {
                    { 4, 2 }, 
                    { 1, 5 }
                };
            var multiplied = MatrixMultiplication(matrixA, matrixB);

            for (int row = 0; row < multiplied.GetLength(0); row++)
            {
                for (int col = 0; col < multiplied.GetLength(1); col++)
                {
                    Console.Write(multiplied[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        public static double[,] MatrixMultiplication(double[,] matrixA, double[,] matrixB)
        {
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                throw new ArgumentOutOfRangeException
                    ("Number of columns of the first Matrix should be equal to the rows of the second Matrix!");
            }

            var cols = matrixA.GetLength(1);

            var matrixResult = new double[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (int row = 0; row < matrixResult.GetLength(0); row++)
            {
                for (int col = 0; col < matrixResult.GetLength(1); col++)
                {
                    for (int i = 0; i < cols; i++)
                    {
                        matrixResult[row, col] += matrixA[row, i] * matrixB[i, col];
                    }
                }
            }

            return matrixResult;
        }
    }
}