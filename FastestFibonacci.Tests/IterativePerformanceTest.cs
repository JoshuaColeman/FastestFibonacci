using FastestFibonacci.CoreLib;
using System;
using Xunit;

namespace FastestFibonacci.Tests
{
    /// <summary>
    /// Test the performance of the iterative impl
    /// </summary>
    public class IterativePerformanceTest
    {
        [Fact]
        public void Calculate_Fibonacci_25()
        {
            var recursiveImpl = new IterativeFibonacciImpl();
            recursiveImpl.CalculateFibonacci(25);
        }

        [Fact]
        public void Calculate_Fibonacci_40()
        {
            var recursiveImpl = new IterativeFibonacciImpl();
            recursiveImpl.CalculateFibonacci(40);
        }

        [Fact]
        public void Calculate_Fibonacci_45()
        {
            var recursiveImpl = new IterativeFibonacciImpl();
            recursiveImpl.CalculateFibonacci(45);
        }

        [Fact]
        public void Calculate_Fibonacci_500()
        {
            var recursiveImpl = new IterativeFibonacciImpl();
            recursiveImpl.CalculateFibonacci(500);
        }

        [Fact]
        public void Calculate_Fibonacci_15000()
        {
            var recursiveImpl = new IterativeFibonacciImpl();
            recursiveImpl.CalculateFibonacci(15000);
        }
    }
}
