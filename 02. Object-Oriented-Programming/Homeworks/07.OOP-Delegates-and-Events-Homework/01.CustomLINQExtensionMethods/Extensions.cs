using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(
            this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var element in collection)
            {

                if (!predicate(element))
                {
                    result.Add(element);
                }

            }
            return result;
        }

        public static TSelector Max<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> selectFunc)
            where TSelector : IComparable
        {
            if (collection == null)
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            TSelector maxSelector = selectFunc(collection.First());

            foreach (var elemnt in collection)
            {
                if (maxSelector.CompareTo(selectFunc(elemnt)) < 0)
                {
                    maxSelector = selectFunc(elemnt);
                }
            }

            return maxSelector;
        }
    }
}
