using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static bool FindNum(int num)
        {
            int previous;
            int thisCurrent=0;
            int next = 1;

            while (thisCurrent != num && thisCurrent <= num)
            {
                previous = thisCurrent;
                thisCurrent = next;
                next = thisCurrent + previous;
            }
            return thisCurrent == num;
        }
    

        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Is it a Fibonacci number? {0}", FindNum(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect number");
            }
            Console.ReadKey();
        }
    }
}
