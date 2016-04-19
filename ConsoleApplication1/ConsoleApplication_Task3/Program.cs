using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = String.Empty;
            int num;
            double dNum;
            List<string> strList = new List<string>();
            List<int> intList = new List<int>();
            List<double> doubleList = new List<double>();
            do
            {
                s = Console.ReadLine();
                string[] sa = s.Split(new char[] { ' ' });
                foreach (string el in sa)
                {
                    if (Int32.TryParse(el, out num))
                    {
                        intList.Add(num);
                    }
                    else if(Double.TryParse(el, out dNum))
                    {
                        doubleList.Add(dNum);
                    }
                    else
                    {
                        strList.Add(el);
                    }
                }

                if (intList.Count != 0)
                {
                    Console.WriteLine("Integer numbers:");
                    foreach (int x in intList)
                    {
                        Console.WriteLine("{0,22}", x);
                    }
                    Console.WriteLine("Average = " + (double)intList.Sum() / intList.Count);
                }
                if (doubleList.Count != 0)
                { 
                    Console.WriteLine("Real numbers:");
                    foreach (double d in doubleList)
                    {
                        Console.WriteLine("{0,22}", d);
                    }

                    Console.WriteLine("Average = " + (double)doubleList.Sum() / doubleList.Count);
                }

                strList.Sort(delegate (string s1, string s2)
                {
                    return s1.Length - s2.Length;
                });

                foreach (string word in strList)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine("type \"q\" to exit");

            }
            while (s != "q");
            
        }
    }
}
