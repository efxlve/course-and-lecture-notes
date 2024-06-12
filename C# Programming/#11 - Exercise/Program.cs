using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter number 2: ");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(" ");

            decimal addition = number1 + number2;
            decimal subtraction = number1 - number2;
            decimal multiplication = number1 * number2;
            decimal division = number1 / number2;
            decimal modulo = number1 % number2;

            Console.WriteLine("Addition : " + addition);
            Console.WriteLine("Subtraction: " + subtraction);
            Console.WriteLine("Multiplication:" + multiplication);
            Console.WriteLine("Division: " +  division);
            Console.WriteLine("Modulo: " + modulo);

            Console.ReadLine();
        }
    }
}
