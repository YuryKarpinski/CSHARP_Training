using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            //All chars to lower case
            s = s.ToLower();
            
            //Current time
            DateTime d = DateTime.Now;
            
            //Definig sentences, adding date to the begining
            s = s.Replace(". ", $".\n{d: dd:mm:yyyy HH:ss:msms} ");
            s = s.Replace("! ", $"!\n{d: dd:mm:yyyy HH:ss:msms} ");
            s = s.Replace("? ", $"?\n{d: dd:mm:yyyy HH:ss:msms} ");
            
            // Adding date to the first sentence
            s = $"{d : dd:mm:yyyy HH:ss:msms} " + s;
            
            //printing result
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
