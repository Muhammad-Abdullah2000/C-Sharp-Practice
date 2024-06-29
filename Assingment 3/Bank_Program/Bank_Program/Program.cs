using System;

namespace Bank_Program
{

    class bank
    {

        string name;
        int account;
        double withdraw;
        double dep;
        double total;
        private int balance = 100000;

        public void savingaccount()
        {
            Console.WriteLine("Enter Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            dep = Convert.ToDouble(Console.ReadLine());
            total = balance + dep;

          
           
            Console.WriteLine("Total Balance in the account is : " + total);

        }
        public void currentAccount()
        {
            Console.WriteLine("Enter Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= balance)
            {
                total = balance - withdraw;
                

                Console.WriteLine("After Withdraw balnace in the account is: " + total);
            }
            else
                Console.WriteLine("Withdraw Ammount does not Exist ");
        }
        public void checkAccount()
        {
            Console.WriteLine("The balance in your account is: " + balance);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bank b = new bank();
            int num;

            Console.WriteLine("Press 1 for Deposit the amount: ");
            Console.WriteLine("Press 2 to withdraw the amount: ");
            Console.WriteLine("Press 3 to check the amount: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                b.savingaccount();

            }
            else if (num == 2)
            {
                b.currentAccount();

            }
            else if(num == 3)
            {
                b.checkAccount();
            }
            else
            {
                Console.WriteLine("Invalid selection");

            }

            Console.ReadKey();
        }
    }
}











