using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MatrixShuffle
{
    public class MatrixShuffle
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int maxRotations = n * n - (n * n - text.Length);
            char[] array = text.ToCharArray();

            List<string> evenList = new List<string>();
            List<string> oddList = new List<string>();

            var matrix = FillMatrix(n, maxRotations, array);
            ExtractAllLettersInChessboard(n, evenList, matrix, oddList);

            string textList = string.Join("", evenList.ToArray()) + string.Join("", oddList.ToArray());
            string[] value = textList.Split(' ');
            string finalText = ConvertStringArrayToString(value);

            if (IsPalindrome(finalText))
            {
                Console.Write("<div style='background-color:#4FE000'>");
            }
            else
            {
                Console.Write("<div style='background-color:#E0000F'>");
            }

            for (int i = 0; i < evenList.Count; i++)
            {
                Console.Write(evenList[i]);
            }
            for (int i = 0; i < oddList.Count; i++)
            {
                Console.Write(oddList[i]);
            }
            Console.WriteLine("</div>");


        }

        private static void ExtractAllLettersInChessboard(int n, List<string> evenList, char[,] matrix, List<string> oddList)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col % 2 == 0 && row % 2 == 0)
                    {
                        evenList.Add(matrix[row, col].ToString());
                    }
                    else if (col % 2 != 0 && row % 2 == 0)
                    {
                        oddList.Add(matrix[row, col].ToString());
                    }

                    if (col % 2 != 0 && row % 2 != 0)
                    {
                        evenList.Add(matrix[row, col].ToString());
                    }
                    else if (col % 2 == 0 && row % 2 != 0)
                    {
                        oddList.Add(matrix[row, col].ToString());
                    }
                }
            }
        }

        private static char[,] FillMatrix(int n, int maxRotations, char[] array)
        {
            int row = 0;
            int col = 0;
            char[,] matrix = new char[n, n];
            string direction = "right";
            for (int i = 0; i < maxRotations; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = array[i];


                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }
            return matrix;
        }
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        static string ConvertStringArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
            }
            return builder.ToString();
        }
    }
}
