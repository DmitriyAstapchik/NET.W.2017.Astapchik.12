using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using NUnit.Framework;

namespace Homework.Tests
{
    [TestFixture]
    public class FibonacciGeneratorTests
    {
        // test cases
        public static IEnumerable GenerateSequenceTestCases
        {
            get
            {
                yield return new TestCaseData(10u).Returns(new BigInteger[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 });
                yield return new TestCaseData(5u).Returns(new BigInteger[] { 1, 2, 3, 5, 8 });
                yield return new TestCaseData(20u).Returns(new BigInteger[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946 });
                yield return new TestCaseData(0u).Returns(new BigInteger[] { });
                yield return new TestCaseData(1u).Returns(new BigInteger[] { 1 });
                yield return new TestCaseData(2u).Returns(new BigInteger[] { 1, 2 });
            }
        }

        [TestCaseSource("GenerateSequenceTestCases")]
        public IEnumerable<BigInteger> GenerateSequenceTest(uint length)
        {
            return FibonacciGenerator.GenerateSequence(length);
        }
    }
}
