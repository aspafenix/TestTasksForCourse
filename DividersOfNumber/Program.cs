using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividersOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input a number: ");
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("All dividers of {0}:", number);
                    for (int i = number; i > 0; i--)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect number");
                }
                Console.WriteLine("Press any key to continue or esc to exit ...");
                ConsoleKeyInfo k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.Escape)
                    break;
            }        
        }
    }
}
