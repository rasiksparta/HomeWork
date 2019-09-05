using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public class CalculatorFunction
    {

        public CalculatorFunction()
        {

        }

        public double Divide(double arg0, double arg1)
        {
            return arg0 / arg1;
        }

        public double Multiply(double arg0, double arg1)
        {
            return arg0 * arg1;
        }

        public double Add(double arg0, double arg1)
        {
            return arg0 + arg1;
        }

        public double Subtract(double arg0, double arg1)
        {
            return arg0 - arg1;
        }
    }
}
