using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // And Operator (&&)
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool returnValue = username == "admin" && password == "123";
            Console.WriteLine(returnValue);

            // Or Operator (||)
            bool returnValue2 = username == "admin" || password == "123";
            Console.WriteLine(returnValue2);

            Console.ReadLine();
        }
    }
}
