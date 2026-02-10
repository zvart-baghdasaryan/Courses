using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankRelated
{
    public abstract class BankAccount
    {
        public void getMessage()
        {
            Console.WriteLine("Welcome to ABC Bank!!");
        }
        public abstract void deposit();
        public abstract void withdraw();
        public abstract void balance();
    }

    public class SavingAccount : BankAccount
    {
        public override void deposit()
        {
            Console.WriteLine("Balance in Saving Account.");
        }
        public override void withdraw()
        {
            Console.WriteLine("Deposit in Saving Account.");
        }
        public override void balance()
        {
            Console.WriteLine("Withdraw in Saving Account.");
        }
    }
}