using System;
using System.Collections.Generic;

namespace Homework
{
    /// <summary>
    /// presents methods for a binary search of an element
    /// </summary>
    public static class BinarySearcher
    {
        /// <summary>
        /// searches an element in an array using specified <paramref name="comparison"/>
        /// </summary>
        /// <typeparam name="T">type of an element to search</typeparam>
        /// <param name="array">array for a search</param>
        /// <param name="elem">element to search</param>
        /// <param name="comparison">compare method</param>
        /// <returns>position of <paramref name="elem"/> in <paramref name="array"/> or -1 if not found</returns>
        /// <exception cref="InvalidOperationException">objects of type <typeparamref name="T"/> are not comparable</exception>
        public static int BinarySearch<T>(T[] array, T elem, Comparison<T> comparison = null)
        {
            if (comparison == null)
            {
                if (elem is IComparable<T> element)
                {
                    comparison = (T left, T right) => element.CompareTo(right);
                }
                else
                {
                    throw new InvalidOperationException($"cannot compare objects of type {typeof(T)}");
                }
            }

            if (array.Length == 0 || comparison(elem, array[0]) < 0 || comparison(elem, array[array.Length - 1]) > 0)
            {
                return -1;
            }

            int first = 0;
            int last = array.Length;

            while (first < last)
            {
                int mid = first + ((last - first) / 2);

                if (comparison(elem, array[mid]) <= 0)
                {
                    last = mid;
                }
                else
                {
                    first = mid + 1;
                }
            }

            if (comparison(elem, array[last]) == 0)
            {
                return last;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// searches an element in an array using specified <paramref name="comparer"/>
        /// </summary>
        /// <param name="array">array for a search</param>
        /// <param name="elem">element to search</param>
        /// <param name="comparer">comparer object</param>
        /// <returns>position of <paramref name="elem"/> in <paramref name="array"/> or -1 if not found</returns></returns>
        public static int BinarySearch<T>(T[] array, T elem, IComparer<T> comparer)
        {
            return BinarySearch(array, elem, comparer.Compare);
        }
    }
}
