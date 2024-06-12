using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Convert_and_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "100";
            int number = int.Parse(text);
            int number2 = Convert.ToInt32(text);

            Console.WriteLine(number);
            Console.WriteLine(number2);

            string text2 = "True";
            bool b1 = bool.Parse(text2);
            bool b2 = Convert.ToBoolean(text2);

            Console.WriteLine(b1);
            Console.WriteLine(b2);

            string text3 = null;
            //decimal d1 = decimal.Parse(text3);
            decimal d2 = Convert.ToDecimal(text3);

            bool b3 = Convert.ToBoolean(text3);

            //Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(b3);

            Console.ReadLine();
        }
    }
}
