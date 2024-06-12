using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Addition Operator (+)
            Console.WriteLine("======= Addition Operator (+) =======");

            // int + int (return int)
            int n1 = 10;
            int n2 = 20;
            int n3 = n1 + n2;
            Console.WriteLine(n3);

            byte n4 = 10;
            byte n5 = 10;
            //byte n6 = n4 + n5;
            int n6 = n4 + n5;
            Console.WriteLine(n6);


            // string + int (return string)
            string txt1 = "Hello ";
            int number1 = 10;
            string txt2 = txt1 + number1;
            Console.WriteLine(txt2);


            // int + string (return string)
            string txt3 = number1 + txt1;
            Console.WriteLine(txt3);

            // string + string (return string)
            string txt4 = "World!";
            string txt5 = txt1 + txt4;
            Console.WriteLine(txt5);


            // Subtraction Operator (-)
            Console.WriteLine("======= Subtraction Operator (-) =======");

            // byte, int, double, float, decimal

            // int
            int SO_n1 = 100;
            int SO_n2 = 50;
            int SO_n3 = SO_n1 - SO_n2;
            Console.WriteLine(SO_n3);

            // byte
            byte SO_b1 = 100;
            byte SO_b2 = 50;
            //byte SO_b3 = SO_b1 - SO_b2;
            int SO_b3 = SO_b1 - SO_b2;
            Console.WriteLine(SO_b3);

            // Multiplication Operator (*)
            Console.WriteLine("======= Multiplication Operator (*) =======");

            // byte, int, double, float, decimal

            double MO_n1 = 10.4;
            double MO_n2 = 10.6;
            double MO_n3 = MO_n1 * MO_n2;
            Console.WriteLine(MO_n3);

            int MO_n4 = (int) (MO_n1 * MO_n2);
            Console.WriteLine(MO_n4);

            // Division Operator (/)
            Console.WriteLine("======= Division Operator (/) =======");

            int DO_n1 = 10;
            int DO_n2 = 2;
            int DO_n3 = DO_n1 / DO_n2;
            Console.WriteLine(DO_n3);

            //int DO_n4 = 0;
            //int DO_n5 = DO_n1 / DO_n4;
            //Console.WriteLine(DO_n5);




            // SPECIAL OPERATORS
            Console.WriteLine(" ");
            Console.WriteLine("[======= SPECIAL OPERATORS =======]");
            Console.WriteLine(" ");

            // %
            Console.WriteLine("------ % ------");

            int number001 = 10;
            int number002 = 2;
            int number003 = number001 % number002;
            Console.WriteLine(number003);

            // ++
            Console.WriteLine("------ ++ ------");

            int number004 = 10;

            int number005 = number004++;
            Console.WriteLine(number005);

            number004 = 10;


            int number006 = ++number004;
            Console.WriteLine(number006);

            number004 = 10;

            int number007 = (number004++);
            Console.WriteLine(number007);

            // --
            Console.WriteLine("------ -- ------");

            int number008 = 10;
            int number009 = number008--;
            Console.WriteLine(number009);

            number008 = 10;
            int number010 = --number008;
            Console.WriteLine(number010);


            Console.ReadLine();
        }
    }
}
