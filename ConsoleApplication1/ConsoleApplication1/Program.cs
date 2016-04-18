using ClassLib;
using System;
using System.Collections;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using ConsoleApplication1;

namespace ConsoleApp
{
    class Program
    {
        static int a, b;
        static void Main(string[] args)
        {
            // Initialization of values
            string init = ConfigurationManager.AppSettings["init"];
            switch (init)
            {
                case "console":
                    Console.WriteLine("Please enter 2 numbers");
                    a = Int32.Parse(Console.ReadLine());
                    b = Int32.Parse(Console.ReadLine());
                    break;
                case "resource":
                    a = Int32.Parse(Resource1.ResourceManager.GetString("a"));
                    b = Int32.Parse(Resource1.ResourceManager.GetString("b"));
                    break;
            }

            //Choose of methods to execute
            string executionMethod = ConfigurationManager.AppSettings["executionMethod"];
            switch (executionMethod)
            {
                case "Summ":
                    Sum();
                    break;
                case "UseCalc":
                    UseCalc();
                    break;
            }

            //And final
            Console.ReadLine();
        }

        static void Sum()
        {
            int sum = a + b;
            Console.WriteLine("a + b = " + sum);
        }

        static void UseCalc()
        {
            
            Calc calculator = new Calc();
            Console.WriteLine("a + b = " + calculator.Summ(a, b));
            Console.WriteLine("a - b = " + calculator.Difference(a, b));
            Console.WriteLine("a * b = " + calculator.Multiply(a, b));
            Console.WriteLine("a / b = " + calculator.Division(a, b));
        }

    }
}
