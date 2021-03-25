using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastestFibonacci.CoreLib
{
    /// <summary>
    /// Iterative implementation for Fibonacci generation
    /// </summary>
    public class IterativeFibonacciImpl : IFibonacciCalculator
    {
        /// <summary>
        /// Iteratively calculates Fibonacci
        /// </summary>
        /// <param name="input">desired fibonacci value</param>
        /// <returns>result of calculation</returns>
        public ulong CalculateFibonacci(ulong input)
        {

            ulong runningValue = 0;
            ulong lastValue = 0;
            for (ulong i = 1; i <= input; ++i)
            {
                if (i == 1)
                {
                    runningValue = 1;
                    lastValue = 0;
                }
                else
                {
                    ulong tempValue = runningValue;
                    runningValue += lastValue;
                    lastValue = tempValue;
                }
            }

            return runningValue;
        }
    }
}
