using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Homework.Tests
{
    [TestFixture]
    public class BinarySearcherTests
    {
        [Test, TestCaseSource(typeof(BinarySearcherTestsData), "IntComparisonTestCases")]
        public int BinarySearchIntComparisonTest(int[] array, int elem, Comparison<int> comparison)
        {
            return BinarySearcher.BinarySearch(array, elem, comparison);
        }

        [Test, TestCaseSource(typeof(BinarySearcherTestsData), "IntComparerTestCases")]
        public int BinarySearchIntComparerTest(int[] array, int elem, IComparer<int> comparer)
        {
            return BinarySearcher.BinarySearch(array, elem, comparer);
        }

        [Test, TestCaseSource(typeof(BinarySearcherTestsData), "StringComparisonTestCases")]
        public int BinarySearchStringComparisonTest(string[] array, string elem, Comparison<string> comparison)
        {
            return BinarySearcher.BinarySearch(array, elem, comparison);
        }

        [Test, TestCaseSource(typeof(BinarySearcherTestsData), "StringComparerTestCases")]
        public int BinarySearchStringComparerTest(string[] array, string elem, IComparer<string> comparer)
        {
            return BinarySearcher.BinarySearch(array, elem, comparer);
        }

        [Test, TestCaseSource(typeof(BinarySearcherTestsData), "ExceptionTestCases")]
        public void BinarySearchExceptionTest(object[] array, object elem)
        {
            Assert.Throws<InvalidOperationException>(() => BinarySearcher.BinarySearch(array, elem));
        }
    }
}
