using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Comparison_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 90;
            int number2 = 100;

            // Greater (>)
            bool G_result = number1 > number2;
            Console.WriteLine(G_result);

            // Less than (<)
            bool L_result = number1 < number2;
            Console.WriteLine(L_result);

            // Equal (==)
            bool E_result = number1 == number2;
            Console.WriteLine(E_result);

            // Not Equal (!=)
            bool N_result = number1 != number2;
            Console.WriteLine(N_result);

            // Greater is Equal (>=)
            bool GE_result = number1 >= number2;
            Console.WriteLine(GE_result);

            // Less than is Equal (<=)
            bool LE_result = number1 <= number2;
            Console.WriteLine(LE_result);

            // (is)
            object object1 = number1;

            //number1 = (int)object1;
            //number1 = (byte)object1;

            bool isControl = object1 is int;
            bool isControl2 = object1 is byte;
            Console.WriteLine(isControl);
            Console.WriteLine(isControl2);

            // (as)
            string nameSurname = "Lorem Ipsum";
            object objectString = nameSurname;
            string resultString = objectString as string;
            Console.WriteLine(resultString);


            Console.ReadLine();
        }
    }
}
