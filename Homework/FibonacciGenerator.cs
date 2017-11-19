using System.Collections.Generic;
using System.Numerics;

namespace Homework
{
    /// <summary>
    /// class for generating the Fibonacci numbers
    /// </summary>
    public static class FibonacciGenerator
    {
        /// <summary>
        /// generates fibonacci numbers sequence of specified length
        /// </summary>
        /// <param name="length">length of fibonacci sequence</param>
        /// <returns>enumerable sequence</returns>
        public static IEnumerable<BigInteger> GenerateSequence(uint length)
        {
            var fib1 = BigInteger.Zero;
            var fib2 = BigInteger.One;
            for (uint i = 0; i < length; i++)
            {
                yield return fib2 = checked(fib1 + (fib1 = fib2));
            }
        }
    }
}
