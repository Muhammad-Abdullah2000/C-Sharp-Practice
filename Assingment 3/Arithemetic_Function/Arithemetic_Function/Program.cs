using System;
namespace Arithemetic_Function
{
   
    
        public class number
        {
            public float num; 
            public int factorial = 1;
            public void input(){

                Console.WriteLine("Enter the number ");
                num = Convert.ToSingle(Console.ReadLine());
            }

            public bool Whole(){

            if ((num * 10) % 10 == 0){
                return true;
            }
            else{
                return false;
            }
            
        }

            public bool Positive(){

            if (num > 0){

                return true;
            }
            else{

                return false;
            }
            
        }

            public void fact(){

                if (Whole() && Positive())
                {
                for (int i = 1; i <= num; i++)
                {
                    factorial = factorial * i;
                }
              
            }
            
        }
            public void display()
            {
            if (factorial != 0)
            {

                Console.Write("Factorial of " + num + " is: " + factorial);
            }
            else
            {

                Console.WriteLine("Factorial was not calculated.");
            }
            
        }
        
    }

        class Program
        {
            public static void Main(string[] args)
            {

              
            number n = new number();
             n.input();
            n.fact();
                n.display();

                Console.ReadKey();
            }
        }
    }

        
    