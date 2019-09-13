using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    interface IAccount
    {
        void Deposit(int a, int b);
        void Withdraw(int a, int b);
    }
    interface ISavingsAccount
    {
        double AnnualInterest(int a, double b);

    }

}
