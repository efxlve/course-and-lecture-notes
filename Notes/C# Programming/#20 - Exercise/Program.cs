using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            Console.Write("Choose: ");
            string choose = Console.ReadLine();

            Console.Clear();

            decimal number1 = 0, number2 = 0;
            if(choose == "1" || choose == "2" || choose == "3" || choose == "4")
            {
                Console.Write("Enter the number 1 value: ");
                number1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the number 2 value: ");
                number2 = Convert.ToDecimal(Console.ReadLine());
            }

            if (choose == "1")
            {
                decimal addition = number1 + number2;
                Console.WriteLine("Result: " + addition);
            }
            else if (choose == "2")
            {
                decimal subtraction = number1 - number2;
                Console.WriteLine("Result: " + subtraction);
            }
            else if (choose == "3")
            {
                decimal multiplication = number1 * number2;
                Console.WriteLine("Result: " + multiplication);
            }
            else if (choose == "4")
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Divisor value cannot be 0.");
                }
                else
                {
                    decimal division = number1 / number2;
                    Console.WriteLine("Result: " + division);
                }
            }
            else
            {
                Console.WriteLine("Please only enter one of the specified values.");
            }

            Console.ReadLine();
        }
    }
}
