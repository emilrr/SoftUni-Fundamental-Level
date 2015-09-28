using System;
using System.Diagnostics;

namespace Assertions_Homework.Utils
{
    internal static class OperationElementsUtil
    {
        public static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
           where T : IComparable<T>
        {
            // Check for valid collection input
            Debug.Assert(arr != null, "Collection is null!");
            Debug.Assert(arr.Length > 0, "Collection is empty!");

            // Check for valid start and end index
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Value of start index is incorrect!");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "Value of end index is incorrect!");
            Debug.Assert(startIndex + 1 <= endIndex, "start index is greater yhan end index!");

            int minElementIndex = startIndex;

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            // Check if x or y are null
            Debug.Assert(x != null, "X value is null!");
            Debug.Assert(y != null, "Y value is null!");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
