using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Homework.Tests
{
    public class BinarySearcherTestsData
    {
        public static IEnumerable IntComparisonTestCases
        {
            get
            {
                int[] array0 = new int[0];
                yield return new TestCaseData(array0, 0, null).Returns(-1);

                int[] array1 = { 1, 3, 5, 7, 9 };
                yield return new TestCaseData(array1, 0, null).Returns(-1);
                yield return new TestCaseData(array1, 1, null).Returns(0);
                yield return new TestCaseData(array1, 4, null).Returns(-1);
                yield return new TestCaseData(array1, 9, null).Returns(4);
                yield return new TestCaseData(array1, 10, null).Returns(-1);

                var array2 = new int[] { 9, 8, 7, 6, 4, 3, 2 };
                Comparison<int> comparison = (int l, int r) => r.CompareTo(l);
                yield return new TestCaseData(array2, 0, comparison).Returns(-1);
                yield return new TestCaseData(array2, 5, comparison).Returns(-1);
                yield return new TestCaseData(array2, 9, comparison).Returns(0);
                yield return new TestCaseData(array2, 3, comparison).Returns(5);
                yield return new TestCaseData(array2, 10, comparison).Returns(-1);
            }
        }

        public static IEnumerable IntComparerTestCases
        {
            get
            {
                var array = new int[] { 9, 8, 7, 6, 4, 3, 2 };
                var comparer = new IntComparer();
                yield return new TestCaseData(array, 0, comparer).Returns(-1);
                yield return new TestCaseData(array, 5, comparer).Returns(-1);
                yield return new TestCaseData(array, 9, comparer).Returns(0);
                yield return new TestCaseData(array, 3, comparer).Returns(5);
                yield return new TestCaseData(array, 10, comparer).Returns(-1);
            }
        }

        public static IEnumerable StringComparisonTestCases
        {
            get
            {
                string[] array0 = new string[0];
                yield return new TestCaseData(array0, "a", null).Returns(-1);

                string[] array1 = { "a", "b", "c", "v", "z" };
                yield return new TestCaseData(array1, "A", null).Returns(-1);
                yield return new TestCaseData(array1, "a", null).Returns(0);
                yield return new TestCaseData(array1, "d", null).Returns(-1);
                yield return new TestCaseData(array1, "z", null).Returns(4);
                yield return new TestCaseData(array1, "с", null).Returns(-1);

                var array2 = new string[] { "Z", "x", "M", "f", "A" };
                Comparison<string> comparison = (string l, string r) => r.CompareTo(l);
                yield return new TestCaseData(array2, "z", comparison).Returns(-1);
                yield return new TestCaseData(array2, "F", comparison).Returns(-1);
                yield return new TestCaseData(array2, "Z", comparison).Returns(0);
                yield return new TestCaseData(array2, "x", comparison).Returns(1);
                yield return new TestCaseData(array2, "A", comparison).Returns(4);
            }
        }

        public static IEnumerable StringComparerTestCases
        {
            get
            {
                var array = new string[] { "Z", "x", "M", "f", "A" };
                var comparer = new StringComparer();
                yield return new TestCaseData(array, "z", comparer).Returns(-1);
                yield return new TestCaseData(array, "F", comparer).Returns(-1);
                yield return new TestCaseData(array, "Z", comparer).Returns(0);
                yield return new TestCaseData(array, "x", comparer).Returns(1);
                yield return new TestCaseData(array, "A", comparer).Returns(4);
            }
        }

        public static IEnumerable ExceptionTestCases
        {
            get
            {
                var array = new object[5];
                yield return new TestCaseData(array, array[2]);
            }
        }

        private class IntComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y.CompareTo(x);
            }
        }

        private class StringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
