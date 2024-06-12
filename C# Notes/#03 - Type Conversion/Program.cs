using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Type_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversions

            byte number1 = 100; // True
            byte byteMin = byte.MinValue; // 0
            byte byteMax = byte.MaxValue; // 255

            //sayi1 = 256;

            int number2 = 256;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            int number3 = number1; // Implicit Conversions

            Console.WriteLine(number3);

            // Explicit Conversions

            int number4 = 256;

            byte number5 = (byte)number4; // Explicit Conversions

            Console.WriteLine(number5);

            Console.ReadLine();
        }
    }
}
