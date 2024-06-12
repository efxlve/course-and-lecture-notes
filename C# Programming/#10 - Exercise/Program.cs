using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helloo!!");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Birthyear: ");
            int birthyear = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthyear;

            Console.WriteLine("Hello " + name + " " + surname + "! " + "You are " + age + " years old.");

            Console.ReadLine();
        }
    }
}
