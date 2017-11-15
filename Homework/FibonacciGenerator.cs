using System.Collections.Generic;

namespace Homework
{
    /// <summary>
    /// class for generating the Fibonacci numbers
    /// </summary>
    public static class FibonacciGenerator
    {
        /// <summary>
        /// generates fibonacci numbers sequence of specified lengthS
        /// </summary>
        /// <param name="length">length of fibonacci sequence</param>
        /// <returns>enumerable sequence</returns>
        public static IEnumerable<uint> GenerateSequence(uint length)
        {
            for (uint i = 0, fib1 = 0, fib2 = 1; i < length; i++)
            {
                yield return fib2 = NextFib(fib1, fib1 = fib2);
            }
        }

        /// <summary>
        /// calculates next fibonacci number
        /// </summary>
        /// <param name="fib1">first number</param>
        /// <param name="fib2">second number</param>
        /// <returns>next fibonacci number</returns>
        private static uint NextFib(uint fib1, uint fib2)
        {
            return checked(fib1 + fib2);
        }
    }
}
