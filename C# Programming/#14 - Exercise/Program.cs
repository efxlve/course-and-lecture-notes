using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool controlUsername1 = username == "admin";
            bool controlUsername2 = username != "admin";

            bool controlPassword1 = password == "123";
            bool controlPassword2 = password != "123";

            Console.WriteLine(controlUsername1);
            Console.WriteLine(controlUsername2);
            Console.WriteLine(controlPassword1);
            Console.WriteLine(controlPassword2);

            Console.ReadLine();
        }
    }
}
