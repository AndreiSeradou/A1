using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialProgramTask2
{
    static class CalculationOfTheExpression
    {
        static public double Calculation(int n)
        {
            double result = default;

            for(int i = 1; i <= n; i++)
            {
                result += Factorial.CalculationFactorial(i);
            }
            Console.Write("Выражение cтремится к 0 \nОтвет: ");
            return (1 / Factorial.CalculationFactorial(n)) * result;
        }
    }
}
