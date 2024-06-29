using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            String a = Console.ReadLine();
            int reverse = 0;
            int remainder;
          
            int a1 = Convert.ToInt32(a);
            while (a1 != 0)
            {
                remainder = a1 % 10;
                reverse = reverse * 10 + remainder;
                a1 /= 10;
            }
            Console.Write("The Number you Write in reverse form: " + reverse);
            Console.ReadKey();
        }
    }
}
