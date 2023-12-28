using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal abstract class BankAccount
    {
        public abstract void deposit();

        public abstract void withdraw();

        public abstract void balance();
    }

    internal class SavingAccount : BankAccount
    {
        public override void balance()
        {
            Console.WriteLine("This is Balance");
        }

        public override void deposit()
        {
            Console.WriteLine("This is Deposit");
        }

        public override void withdraw()
        {
            Console.WriteLine("This is Withdraw");
        }
    }
}
