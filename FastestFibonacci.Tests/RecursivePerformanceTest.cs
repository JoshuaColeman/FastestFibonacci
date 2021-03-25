using FastestFibonacci.CoreLib;
using System;
using Xunit;

namespace FastestFibonacci.Tests
{
    /// <summary>
    /// Test the performance of the recursive impl that doesn't have caching
    /// </summary>
    public class RecursivePerformanceTest
    {
        [Fact]
        public void Calculate_Fibonacci_25()
        {
            var recursiveImpl = new RecursiveFibonacciImpl();
            recursiveImpl.CalculateFibonacci(25);
        }

        [Fact]
        public void Calculate_Fibonacci_40()
        {
            var recursiveImpl = new RecursiveFibonacciImpl();
            recursiveImpl.CalculateFibonacci(40);
        }

        [Fact]
        public void Calculate_Fibonacci_45()
        {
            var recursiveImpl = new RecursiveFibonacciImpl();
            recursiveImpl.CalculateFibonacci(45);
        }

        // Disabled since it's sooo slow
        //[Fact]
        //public void Calculate_Fibonacci_500()
        //{
        //    var recursiveImpl = new RecursiveFibonacciImpl();
        //    recursiveImpl.CalculateFibonacci(500);
        //}
    }
}
