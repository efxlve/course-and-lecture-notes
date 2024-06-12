using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Variables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!");

            Console.Write("What's your name? ");
            string name = Console.ReadLine();

            Console.Write("What's your surname? ");
            string surname = Console.ReadLine();

            Console.Write("The city which you are living? ");
            string city = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("City: " + city);

            Console.ReadLine();
        }
    }
}
