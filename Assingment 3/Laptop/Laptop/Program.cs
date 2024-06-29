using System;
namespace Laptop
{
    class laptop
    {
        string brand;
        string model;
        string colour;
        int serial;
        int  RAM;
        float price;
        float speed; 
        float scrSize;
        int num;
       
       public laptop(){

            brand = "Haier";
            model = "b11";
            colour = "Grey";
            serial = 11223344;
            RAM = 4;
            price = 35000f;
            speed = 2f;
            scrSize = 10f;
        }
        public laptop(string b, string m, string c, int s, int r,float p, float pr, float sc)
        {
            brand = b;
            model = m;
            colour = c;
            serial = s;
            RAM = r;
            price = p;
            speed = pr;
            scrSize = sc;
        }
        public void UpgradeRam()
        {
            int num;
            Console.WriteLine("Do you want to upgrade the RAM? ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                RAM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The RAM is ugraged");
            }
            else
            {
                Console.WriteLine("The RAM is not upgraded");
            }


            
           
        }
       
        public void display()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Colour: " + colour);
            Console.WriteLine("Serial: " + serial);
            Console.WriteLine("RAM: " + RAM);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Processor Speed: " + speed);
            Console.WriteLine("Screen Size: " + scrSize);
        }

       
    }

    class Program
    {
        public static void Main(string[] args)
        {
            laptop lp = new laptop();

            lp.UpgradeRam();
                lp.display();

            Console.ReadKey();
        }
    }
}