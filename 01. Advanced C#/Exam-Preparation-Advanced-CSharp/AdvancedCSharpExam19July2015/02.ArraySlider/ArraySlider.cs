namespace _02.ArraySlider
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text.RegularExpressions;

    internal class ArraySlider
    {
        private static void Main(string[] args)
        {
            BigInteger[] arrayNumbers = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse).ToArray();
            int currentIndex = 0;


            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("stop"))
                {
                    break;
                }

                string[] commands = input.Split();
                int offset = int.Parse(commands[0]) % arrayNumbers.Length;
                string operation = commands[1];
                int operand = int.Parse(commands[2]);
                if (offset < 0)
                {
                    offset += arrayNumbers.Length;
                }

                currentIndex = (currentIndex + offset) % arrayNumbers.Length;
                PerformOperation(arrayNumbers, currentIndex, operand, operation);
                //if (arrayNumbers[currentIndex] < 0)
                //{
                //    arrayNumbers[currentIndex] = 0;
                //}
            }

            Console.WriteLine("[{0}]", string.Join(", ", arrayNumbers));
        }

        private static void PerformOperation(BigInteger[] arrayNumbers, int currentIndex, int operand, string operation)
        {
            switch (operation)
            {
                case "&":
                    arrayNumbers[currentIndex] &= operand;
                    break;
                case "|":
                    arrayNumbers[currentIndex] |= operand;
                    break;
                case "^":
                    arrayNumbers[currentIndex] ^= operand;
                    break;
                case "+":
                    arrayNumbers[currentIndex] += operand;
                    break;
                case "-":
                    arrayNumbers[currentIndex] -= operand;
                    break;
                case "*":
                    arrayNumbers[currentIndex] *= operand;
                    break;
                case "/":
                    arrayNumbers[currentIndex] /= operand;
                    break;
            }

            if (arrayNumbers[currentIndex] < 0)
            {
                arrayNumbers[currentIndex] = 0;
            }
        }
    }
}
