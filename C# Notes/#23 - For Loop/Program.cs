using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _23___For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-) General use of for loop.
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 2-) Let's print the even numbers between 1 and 100 on the screen.
            //for (int i = 0;i <= 100;i++)
            //{
            //    if (i % 2 == 0) Console.WriteLine(i);
            //}
            #endregion

            #region 3-) What is the sum of even numbers between 1 and 100?
            //int sum = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //        Console.WriteLine(sum);
            //    }
            //}
            #endregion

            #region 4-) An application that takes the factorial of the number entered by the user on the keyboard and prints it on the screen.
            //Console.Write("Please enter the value you want to calculate factorial: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int factorial = 1;

            //for (int i = number;  i > 1; i--)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine("{0}. factorial result of the value: {1}", number, factorial);
            #endregion

            #region 5-) Create infinite loop.
            //int counter = 0;
            //for (; ; )
            //{
            //    counter++;

            //    //if (counter == 5) break;

            //    if (counter == 5) continue;

            //    Console.WriteLine("Helloo!!");
            //}
            #endregion

            #region 6-) Use of nested for loop.
            //for (int i = 1; i <= 20; i++) 
            //{ 
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 7-) Exercise: Multiplication Table
            for (int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    int result = i * j;
                    Console.Write("{0} * {1} = {2}\t",i , j, result);
                }
                Console.WriteLine();
            }
            #endregion

            Console.ReadLine();
        }
    }
}
