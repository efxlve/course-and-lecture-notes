using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st exam grade: ");
            decimal exam1 = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            Console.Write("Enter the 2nd exam grade: ");
            decimal exam2 = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            Console.Write("Enter the 3rd exam grade: ");
            decimal exam3 = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            decimal average = (exam1 + exam2 + exam3) / 3;
            bool controlResult = average >= 45;
            Console.WriteLine("Is your average greater than or equal to 45? --> " + controlResult);


            Console.ReadLine();
        }
    }
}
