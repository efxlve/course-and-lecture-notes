using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Decision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch case
            Console.Write("Which month are we in: ");
            string month = Console.ReadLine();

            switch (month)
            {
                case "January":
                    Console.WriteLine("01");
                    break;
                case "Februray":
                    Console.WriteLine("02");
                    break;
                case "March":
                    Console.WriteLine("03");
                    break;
                case "April":
                    Console.WriteLine("04");
                    break;
                case "May":
                    Console.WriteLine("05");
                    break;
                case "June":
                    Console.WriteLine("06");
                    break;
                case "July":
                    Console.WriteLine("07");
                    break;
                case "August":
                    Console.WriteLine("08");
                    break;
                case "September":
                    Console.WriteLine("09");
                    break;
                case "October":
                    Console.WriteLine("10");
                    break;
                case "November":
                    Console.WriteLine("11");
                    break;
                case "December":
                    Console.WriteLine("12");
                    break;
                default:
                    Console.WriteLine("You have entered a value other than the specified values.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
