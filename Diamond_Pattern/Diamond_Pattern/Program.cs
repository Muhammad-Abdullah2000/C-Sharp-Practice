using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
             
            Console.WriteLine("Displaying the pattern: ");

            for (int i = 0; i <= a; i++)
            {
                for (int j = 1; j <= a - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (int i = a - 1; i >= 1; i--)
            {
                for (int j  = 1; j <= a - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}

