using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            string text = "True";
            bool b1 = Convert.ToBoolean(text);
            Console.WriteLine(b1);

            // Exercise 2
            int number = 100;
            byte byteVal = Convert.ToByte(number);
            float floatVal = number;
            Console.WriteLine(byteVal);
            Console.WriteLine(floatVal);

            // Exercise 3
            byte byteVal2 = 10;
            decimal decimalVal = byteVal2;
            Console.WriteLine(decimalVal);

            Console.ReadLine();
        }
    }
}
