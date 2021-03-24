using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastestFibonacci.CoreLib
{
    /// <summary>
    /// Recursive implementation for Fibonacci generation, that leverages caching
    /// </summary>
    public class RecursiveCachingFibonacciImpl : IFibonacciCalculator
    {
        // Pregenerate the first two fibonacci values to cache or special cases
        static Dictionary<ulong, ulong> CachedFibonacciValues = new Dictionary<ulong, ulong>
        {
            { 0, 0 },
            { 1, 1 }
        };

        /// <summary>
        /// Recursively calculates Fibonacci
        /// </summary>
        /// <param name="input">desired fibonacci value</param>
        /// <returns>result of calculation</returns>
        public ulong CalculateFibonacci(ulong input)
        {
            if (CachedFibonacciValues.TryGetValue(input, out ulong cachedResult))
            {
                return cachedResult;
            }

            var result = CalculateFibonacci(input - 1) + CalculateFibonacci(input - 2);
            CachedFibonacciValues.Add(input, result);
            return result;
        }
    }
}
