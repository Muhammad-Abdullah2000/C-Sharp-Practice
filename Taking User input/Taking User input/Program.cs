﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taking_User_input
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Ok your name is: " + name);
            Console.ReadKey();
        }
    }
}
