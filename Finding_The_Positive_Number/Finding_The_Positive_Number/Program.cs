using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_The_Positive_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            String a = Console.ReadLine();
            int a1 = Convert.ToInt32(a);
            if(a1 > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is negative.");
            }
          
            Console.ReadKey();

        }
    }
}
