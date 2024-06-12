using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your user code: ");
            string usercode = Console.ReadLine().ToUpper();

            if (usercode == "ABC" || usercode == "123" || usercode == "CMK")
            {
                Console.WriteLine("Your login process is successful.");
            }
            else if (usercode == "HHH" || usercode == "BBB" || usercode == "MMM")
            {
                Console.WriteLine("Your user login has been locked.");
            }
            else
            {
                Console.WriteLine("Incorrect user code.");
            }

            Console.ReadLine();
        }
    }
}
