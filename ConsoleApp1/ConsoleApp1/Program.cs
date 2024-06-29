using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            bool IsPrime = true;
            Console.WriteLine("Prime Numbers: ");
            for(int i = 2; i <= 100; i++)
            {
                for(int j = 2; j < 100; j++)
                {
                    if(i != j && i%j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.Write("\t" + i);
                }
                IsPrime = true;
            }
            Console.ReadKey();
        }
        
    }
}
