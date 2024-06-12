using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the grade point average calculation system!");

            Console.Write("1. Enter your exam score: ");
            decimal exam1 = decimal.Parse(Console.ReadLine());

            Console.Write("2. Enter your exam score: ");
            decimal exam2 = decimal.Parse(Console.ReadLine());

            Console.Write("3. Enter your exam score: ");
            decimal exam3 = decimal.Parse(Console.ReadLine());

            decimal average = (exam1 + exam2 + exam3) / 3;

            if (average < 45)
                Console.WriteLine("You Failed the Lesson!");
            else if (average >= 45 &&  average < 70)
                Console.WriteLine("You passed the lesson with an average grade.");
            else if (average >= 70 && average < 90)
                Console.WriteLine("You passed the lesson with a good average grade.");
            else if (average >= 90 && average <= 100)
                Console.WriteLine("You have successfully passed the lesson.");
            else
                Console.WriteLine("Please check the values ​​you entered.");
            Console.ReadLine();
        }
    }
}
