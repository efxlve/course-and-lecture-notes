using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your user code: ");
            string userCode = Console.ReadLine();
            
            switch (userCode)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("You have admin authority.");
                    break;
                case "DD":
                    Console.WriteLine("You have strong user authority.");
                    break;
                case "FF":
                case "EE":
                case "GG":
                    Console.WriteLine("You have standard user authority.");
                    break;
                default:
                    Console.WriteLine("Incorrect user code!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
