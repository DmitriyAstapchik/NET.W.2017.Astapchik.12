using System.Collections.Generic;
using NUnit.Framework;

namespace Homework.Tests
{
    [TestFixture]
    public class FibonacciGeneratorTests
    {
        [TestCase(10u, ExpectedResult = new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 })]
        [TestCase(5u, ExpectedResult = new int[] { 1, 2, 3, 5, 8 })]
        [TestCase(20u, ExpectedResult = new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946 })]
        [TestCase(0u, ExpectedResult = new int[] { })]
        [TestCase(1u, ExpectedResult = new int[] { 1 })]
        [TestCase(2u, ExpectedResult = new int[] { 1, 2 })]
        public IEnumerable<uint> GenerateSequenceTest(uint length)
        {
            return FibonacciGenerator.GenerateSequence(length);
        }
    }
}
