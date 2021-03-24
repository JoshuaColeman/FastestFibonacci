using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastestFibonacci.CoreLib
{
    /// <summary>
    /// Recursive implementation for Fibonacci generation
    /// </summary>
    public class RecursiveFibonacciImpl : IFibonacciCalculator
    {
        /// <summary>
        /// Recursively calculates Fibonacci
        /// </summary>
        /// <param name="input">desired fibonacci value</param>
        /// <returns>result of calculation</returns>
        public ulong CalculateFibonacci(ulong input)
        {
            if(input == 0)
            {
                return 0;
            }
            else if(input == 1)
            {
                return 1;
            }
            return CalculateFibonacci(input - 1) + CalculateFibonacci(input - 2);
        }
    }
}
