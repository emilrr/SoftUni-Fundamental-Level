using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceInMatrix
{
    static void Main(string[] args)
    {
        int rows = Nakov.IO.Cin.NextInt();
        int cols = Nakov.IO.Cin.NextInt();
        string[,] matrix = new string[rows, cols];
        EnterMatrix(rows, cols, matrix);

        int bestSequence = int.MinValue;
        string bestValue = string.Empty;
        

        bestSequence = CheckHorizontal(rows, cols, matrix, bestSequence, ref bestValue);

        bestSequence = CheckVertical(cols, rows, matrix, bestSequence, ref bestValue);

        bestSequence = CheckDiagonal(cols, rows, matrix, bestSequence, ref bestValue);

        Console.Write(bestValue);
        for (int i = 1; i < bestSequence; i++)
        {
            Console.Write(", {0}", bestValue);
        }

        Console.WriteLine();
    }

    private static int CheckDiagonal(int cols, int rows, string[,] matrix, int bestSequence, ref string bestValue)
    {
        for (int col = 0; col < cols - 1; col++) 
        {
            int sum = 1;
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row, col].Equals(matrix[row + 1, col + 1]))
                {
                    sum++;

                    if (sum > bestSequence)
                    {
                        bestSequence = sum;
                        bestValue = matrix[row, col];
                    }
                    col++;
                }
                else
                {
                    break;
                }
            }
        }
        return bestSequence;
    }

    private static int CheckVertical(int cols, int rows, string[,] matrix, int bestSequence, ref string bestValue)
    {
        for (int col = 0; col < cols; col++) 
        {
            int sum = 1;
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row, col].Equals(matrix[row + 1, col]))
                {
                    sum++;
                    if (sum > bestSequence)
                    {
                        bestSequence = sum;
                        bestValue = matrix[row, col];
                    }
                }
                else
                {
                    break;
                }
            }
        }
        return bestSequence;
    }

    private static int CheckHorizontal(int rows, int cols, string[,] matrix, int bestSequence, ref string bestValue)
    {
        for (int row = 0; row < rows; row++) 
        {
            int sum = 1;
            for (int col = 0; col < cols - 1; col++)
            {
                if (matrix[row, col].Equals(matrix[row, col + 1]))
                {
                    sum++;
                    if (sum > bestSequence)
                    {
                        bestSequence = sum;
                        bestValue = matrix[row, col];
                    }
                }
                else
                {
                    break;
                }
            }
        }
        return bestSequence;
    }

    public static void EnterMatrix(int rows, int cols, string[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                string element = Nakov.IO.Cin.NextToken();
                matrix[row, col] = element;
            }
        }
    }
}
namespace Nakov.IO
{
    using System;
    using System.Text;
    using System.Globalization;

    /// <summary>
    /// Console input helper for C# and .NET. Allows simplified reading of numbers and string
    /// tokens from the console in a way similar to "cin" in C++ and java.util.Scanner in Java.
    /// </summary>
    /// 
    /// <copyright>
    /// (c) Svetlin Nakov, 2011 - http://www.nakov.com
    /// </copyright>
    /// 
    /// <example>
    /// // In C++ we will use "cin >> x >> y;". Using Nakov.IO.Cin we can do the same as follows:
    /// int x = Cin.NextInt();
    /// double y = Cin.NextDouble();
    /// </example>
    /// 
    public static class Cin
    {
        /// <summary>
        /// Reads a string token from the console
        /// skipping any leading and trailing whitespace.
        /// </summary>
        public static string NextToken()
        {
            StringBuilder tokenChars = new StringBuilder();
            bool tokenFinished = false;
            bool skipWhiteSpaceMode = true;
            while (!tokenFinished)
            {
                int nextChar = Console.Read();
                if (nextChar == -1)
                {
                    // End of stream reached
                    tokenFinished = true;
                }
                else
                {
                    char ch = (char)nextChar;
                    if (char.IsWhiteSpace(ch))
                    {
                        // Whitespace reached (' ', '\r', '\n', '\t') -->
                        // skip it if it is a leading whitespace
                        // or stop reading anymore if it is trailing
                        if (!skipWhiteSpaceMode)
                        {
                            tokenFinished = true;
                            if (ch == '\r' && (Environment.NewLine == "\r\n"))
                            {
                                // Reached '\r' in Windows --> skip the next '\n'
                                Console.Read();
                            }
                        }
                    }
                    else
                    {
                        // Character reached --> append it to the output
                        skipWhiteSpaceMode = false;
                        tokenChars.Append(ch);
                    }
                }
            }

            string token = tokenChars.ToString();
            return token;
        }

        /// <summary>
        /// Reads an integer number from the console
        /// skipping any leading and trailing whitespace.
        /// </summary>
        public static int NextInt()
        {
            string token = Cin.NextToken();
            return int.Parse(token);
        }

        /// <summary>
        /// Reads a floating-point number from the console
        /// skipping any leading and trailing whitespace.
        /// </summary>
        /// <param name="acceptAnyDecimalSeparator">
        /// Specifies whether to accept any decimal separator
        /// ("." and ",") or the system's default separator only.
        /// </param>
        public static double NextDouble(bool acceptAnyDecimalSeparator = true)
        {
            string token = Cin.NextToken();
            if (acceptAnyDecimalSeparator)
            {
                token = token.Replace(',', '.');
                double result = double.Parse(token, CultureInfo.InvariantCulture);
                return result;
            }
            else
            {
                double result = double.Parse(token);
                return result;
            }
        }

        /// <summary>
        /// Reads a decimal number from the console
        /// skipping any leading and trailing whitespace.
        /// </summary>
        /// <param name="acceptAnyDecimalSeparator">
        /// Specifies whether to accept any decimal separator
        /// ("." and ",") or the system's default separator only.
        /// </param>
        public static decimal NextDecimal(bool acceptAnyDecimalSeparator = true)
        {
            string token = Cin.NextToken();
            if (acceptAnyDecimalSeparator)
            {
                token = token.Replace(',', '.');
                decimal result = decimal.Parse(token, CultureInfo.InvariantCulture);
                return result;
            }
            else
            {
                decimal result = decimal.Parse(token);
                return result;
            }
        }
    }
}

