using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_Task1
{
    public class Calc
    {
        //public int a, b;

        public int Summ (int a, int b)
        {
            return a + b;
        }

        public int Multiply (int a, int b)
        {
            return a * b;
        }

        public int Difference (int a, int b)
        {
            return a - b;
        }

        public double Division (int a, int b)
        {
            return (double) a / b;
        }
    }
}
