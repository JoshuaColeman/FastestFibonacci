using System;

namespace FastestFibonacci.CoreLib
{
    /// <summary>
    /// Basic inferface to abstract different Fibonacci implementations.
    /// See: https://en.wikipedia.org/wiki/Fibonacci_number for major concepts
    /// </summary>
    public interface IFibonacciCalculator
    {

        /// <summary>
        /// Calculates the specified fibonacci value.
        /// </summary>
        /// <param name="input">the desired fibonacci value to be calculated</param>
        /// <returns>the requested fibonacci number</returns>
        ulong CalculateFibonacci(ulong input);
    }
}
