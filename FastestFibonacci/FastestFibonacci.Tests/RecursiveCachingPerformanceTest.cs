using FastestFibonacci.CoreLib;
using System;
using Xunit;

namespace FastestFibonacci.Tests
{
    /// <summary>
    /// Test the performance of the recursive caching impl
    /// </summary>
    public class RecursiveCachingPerformanceTest
    {
        [Fact]
        public void Calculate_Fibonacci_25()
        {
            var recursiveImpl = new RecursiveCachingFibonacciImpl();
            recursiveImpl.CalculateFibonacci(5);
        }

        [Fact]
        public void Calculate_Fibonacci_40()
        {
            var recursiveImpl = new RecursiveCachingFibonacciImpl();
            recursiveImpl.CalculateFibonacci(40);
        }

        [Fact]
        public void Calculate_Fibonacci_45()
        {
            var recursiveImpl = new RecursiveCachingFibonacciImpl();
            recursiveImpl.CalculateFibonacci(45);
        }

        [Fact]
        public void Calculate_Fibonacci_500()
        {
            var recursiveImpl = new RecursiveCachingFibonacciImpl();
            recursiveImpl.CalculateFibonacci(500);
        }
    }
}
