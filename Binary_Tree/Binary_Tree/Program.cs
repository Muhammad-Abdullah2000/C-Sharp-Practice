using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
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
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
