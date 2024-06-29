using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_pattern
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 5;
            int i1 = 0;
           


            Console.WriteLine("Displaying the pattern: ");

            while(i1 <= a)
            {
                for (int j = 1; j <= a - i1; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i1 - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
                i1++;
            }
            int i2 = a - 1;


            while(i2 >= 1)
            {
                for (int j = 1; j <= a - i2; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i2 - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
                i2--;
            }
            Console.ReadKey();
        }
    }
}
