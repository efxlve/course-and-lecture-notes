using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Decision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if, else if and else
            Console.Write("Enter the 1st number: ");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());
            decimal sum = number1 + number2;

            if (sum >= 100)
            {
                Console.WriteLine("The sum of the values ​​you entered is greater than or equal to 100.");
            }
            else if (sum >= 50)
            {
                Console.WriteLine("The sum of the values ​​you entered is greater than or equal to 50.");
            }
            else
            {
                Console.WriteLine("The sum of the values ​​you entered is less than 50.");  
            }

            Console.ReadLine();
        }
    }
}
