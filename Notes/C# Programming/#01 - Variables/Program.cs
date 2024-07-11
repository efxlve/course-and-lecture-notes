using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String
            Console.WriteLine("+--------String--------+");

            string name = "Efe";
            Console.WriteLine(name);
            name = "Efe2";
            Console.WriteLine(name);

            string birthplace;
            birthplace = "Istanbul";
            Console.WriteLine(birthplace);


            // Char
            Console.WriteLine("+--------Char--------+");

            char value;
            value = 'A';

            char value2 = 'B';

            Console.WriteLine(value);
            Console.WriteLine(value2);
           

            // Byte
            Console.WriteLine("+--------Byte--------+");

            byte value3 = 10;
            Console.WriteLine(value3);

            byte byteMinVal = byte.MinValue;
            byte byteMaxVal = byte.MaxValue;

            Console.WriteLine(byteMinVal);
            Console.WriteLine(byteMaxVal);

            // Int
            Console.WriteLine("+--------Int--------+");

            int value4 = 20;
            Console.WriteLine(value4);

            int intMinVal = int.MinValue;
            int intMaxVal = int.MaxValue;

            Console.WriteLine(intMinVal);
            Console.WriteLine(intMaxVal);

            // Double
            Console.WriteLine("+--------Double--------+");

            double value5 = 10.2;
            double value6 = 10;
            double value7 = 10.9d;

            double doubleMinVal = double.MinValue;
            double doubleMaxVal = double.MaxValue;

            Console.WriteLine(value5);
            Console.WriteLine(value6);
            Console.WriteLine(value7);

            Console.WriteLine(doubleMinVal);
            Console.WriteLine(doubleMaxVal);

            // Decimal
            Console.WriteLine("+--------Decimal--------+");

            decimal value8 = 10.2M;

            decimal decimalMinVal = decimal.MinValue;
            decimal decimalMaxVal = decimal.MaxValue;

            Console.WriteLine(value8);

            Console.WriteLine(decimalMinVal);
            Console.WriteLine(decimalMaxVal);

            // Float
            Console.WriteLine("+--------Float--------+");

            float value9 = 10.2F;

            float floatMinVal = float.MinValue;
            float maxVal = float.MaxValue;

            Console.WriteLine(value9);

            Console.WriteLine(floatMinVal);
            Console.WriteLine(maxVal);

            // Boolean
            Console.WriteLine("+--------Boolean--------+");

            bool value10 = false;
            Console.WriteLine(value10);

            value10 = true;
            Console.WriteLine(value10);

            // Datetime
            Console.WriteLine("+--------Datetime--------+");

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());


            Console.ReadLine();
        }
    }
}
