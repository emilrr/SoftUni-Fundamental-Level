using System;
using System.Collections.Generic;
using System.Linq;

class MatrixShuffling
{
    static void Main()
    {

        int rows = Nakov.IO.Cin.NextInt();
        int cols = Nakov.IO.Cin.NextInt();
        string[,] matrix = new string[rows, cols];
        EnterMatrix(rows, cols, matrix);

        string str = Console.ReadLine();
        string[] tokens = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string input = tokens[0];
        while (input != "END")
        {
            if (input.Equals("swap") && tokens.Length == 5)
            {
                int x1 = int.Parse(tokens[1]);
                int y1 = int.Parse(tokens[2]);
                int x2 = int.Parse(tokens[3]);
                int y2 = int.Parse(tokens[4]);

                if (x1 > rows || x2 > rows || y1 > cols || y2 > cols)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    string array = matrix.ToString();
                    var temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;
                    PrintingMatrix(matrix); // Printing Matrix
                }
            }

            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine();
            str = Console.ReadLine();
            tokens = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            input = tokens[0];

        }
    }

    public static void PrintingMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    public static void EnterMatrix(int rows, int cols, string[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            //str = Console.ReadLine();
            //tokens = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < cols; col++)
            {
                //int element = int.Parse(tokens[col]);
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


