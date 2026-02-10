using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    interface IManageBank
    {
        void openAccount();
        void closeAccount();
    }
    internal interface IBankAccount
    {
        void deposit();
        void withdraw();
        void balance();
    }

    public class SavingAcc : IBankAccount, IManageBank
    {
        public void deposit()
        {
            Console.WriteLine("Balance in Saving Account.");
        }
        public void withdraw()
        {
            Console.WriteLine("Deposit in Saving Account.");
        }
        public void balance()
        {
            Console.WriteLine("Withdraw in Saving Account.");
        }

        public void openAccount()
        {
            Console.WriteLine("Opening Saving Account");
        }
        public void closeAccount()
        {
            Console.WriteLine("Closing Saving Account");
        }
    }
}