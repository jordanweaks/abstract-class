using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    class Program : IAccount , ISavingsAccount
    {
        static void Main(string[] args)
        {
            //Step 1: Create an abstract class Account.
            //Step 2: Define class variable double balance.
            //Step 3: Create methods:
            //1. deposit
            //2. withdraw
            //Note: you need to implement these methods to make changes to the balance in the account.
            //Step 4: Define an abstract method annualInterest(). 
            //Child Class - SavingsAccount
            //Step 1: Create a class SavingsAccount which implements Account class.
            //Step 2: Implement the method annualInterest() which adds 10% interest annualy to your account.

            Program p1 = new Program();
            p1.Deposit(1000, 500);
            p1.Withdraw(1500, 250);

            Console.WriteLine("New savings account balance after annual interest of 10%: $" + p1.AnnualInterest(2000,0.10));
            Console.ReadLine();

        }

       

        public void Deposit(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("New balance after deposit: $" + c);
        }


        public void Withdraw(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("New balance after withdraw: $" + c);
        }
        public double AnnualInterest(int a, double b)
        {
            int c = (int)(a + (a * b));
            return c;
        }


    }
}
