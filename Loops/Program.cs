using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Finished!"); 


            //int number = 110;
            //while (number >= 0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now number is {0}" , number);

            //int num = 10;
            //do
            //{
            //    Console.WriteLine(num);
            //    num--;
            //} while (num >= 11);


            //string[] students = new string[3] { "Engin", "Nisa", "Kubra" };
            //foreach (var student in students) 
            //{ 
            //    Console.WriteLine(student);
            //}

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("Not a prime number.");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            result = NewMethod();
            return result;

            bool NewMethod()
            {
                for (int i = 2; i < number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        i = number;
                    }
                }

                return result;
            }
        }
    }
}
