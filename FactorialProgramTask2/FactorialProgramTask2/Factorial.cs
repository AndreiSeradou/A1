using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialProgramTask2
{
    static class Factorial
    {
        static public double CalculationFactorial(double number)
        {
            return (number == 0) ? 1 : number * CalculationFactorial(number - 1);
        }
    }
}
