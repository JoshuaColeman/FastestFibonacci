using FastestFibonacci.CoreLib;
using System;
using Xunit;

namespace FastestFibonacci.Tests
{
    /// <summary>
    /// This test harness overlooks performance and just verifies that the first 20'ish values are 
    /// correct for implementations.
    /// </summary>
    public class FibonacciSanityCheck
    {
        [Fact]
        public void Recursive_Implementation_Works()
        {
            Test_Fibonacci_Implementation(new RecursiveFibonacciImpl());
        }

        [Fact]
        public void RecursiveCaching_Implementation_Works()
        {
            Test_Fibonacci_Implementation(new RecursiveCachingFibonacciImpl());
        }

        [Fact]
        public void Iterative_Implementation_Works()
        {
            Test_Fibonacci_Implementation(new IterativeFibonacciImpl());
        }

        private void Test_Fibonacci_Implementation(IFibonacciCalculator impl)
        {
            for (ulong i = 0; i < (ulong)fibonacciValues.Length; ++i)
            {
                var expected = fibonacciValues[i];
                var actual = impl.CalculateFibonacci(i);
                Assert.Equal(expected, actual);
            }
        }

        // These are the first however many values of the fibonacci sequence... thanks internet!
        private static ulong[] fibonacciValues = {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987,
            1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393,
            196418, 317811
        };
    }
}
