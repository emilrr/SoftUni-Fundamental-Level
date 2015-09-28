using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        //string str = Console.ReadLine();
        //string[] tokens = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //int rows = int.Parse(tokens[0]);
        //int cols = int.Parse(tokens[1]);
        int rows = Nakov.IO.Cin.NextInt() + 1;
        int cols = Nakov.IO.Cin.NextInt() + 1;
        int[,] matrix = new int[rows, cols];
        int bestRow = 0;
        int bestCol = 0;
        int bestSum = int.MinValue;

        EnterMatrix(rows, cols, matrix);

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("The best platform is:");
        Console.WriteLine("  {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }

    public static void EnterMatrix(int rows, int cols, int[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            //str = Console.ReadLine();
            //tokens = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < cols; col++)
            {
                //int element = int.Parse(tokens[col]);
                int element = Nakov.IO.Cin.NextInt();
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

