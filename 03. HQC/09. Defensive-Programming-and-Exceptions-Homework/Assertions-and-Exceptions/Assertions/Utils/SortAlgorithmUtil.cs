using System;
using System.Diagnostics;

namespace Assertions_Homework.Utils
{
    internal static class SortAlgorithmUtil
    {
        public static void SelectionSort<T>(T[] arr)
            where T : IComparable<T>
        {
            // Check for valid collection input
            Debug.Assert(arr != null, "Collection is null!");
            Debug.Assert(arr.Length > 0, "Collection is emprty!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = OperationElementsUtil.FindMinElementIndex(arr, index, arr.Length - 1);
                OperationElementsUtil.Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }
    }
}
