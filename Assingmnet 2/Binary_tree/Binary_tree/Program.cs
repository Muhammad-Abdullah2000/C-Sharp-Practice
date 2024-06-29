using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int i = 0;
            

            while(i <= 4)
            {
                
                int j = 0;
               while( j <= i)
                {
                    if (a == 1)
                    {
                        Console.Write("0");
                        a = 0;
                    }
                    else if (a == 0)
                    {
                        Console.Write("1");
                        a = 1;
                    }
                    j++;
                }
                Console.Write("\n");
                i++;
            }
            Console.ReadKey();
        }
    }
}
