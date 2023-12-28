using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal interface IBankAccount
    {
        void deposit();
        void balance();
        void withdraw();

    }

    internal interface IBankRegistration
    {
        void createAccount();
        void deleteAccount();
    }

    internal class SavingAcc : IBankAccount, IBankRegistration
    {
        public void balance()
        {
            Console.WriteLine("balance");
        }

        public void createAccount()
        {
            Console.WriteLine("CreateAccount");
        }

        public void deleteAccount()
        {
            Console.WriteLine("DeleteAccount");
        }

        public void deposit()
        {
            Console.WriteLine("deposit");
        }

        public void withdraw()
        {
            Console.WriteLine("withdraw");
        }
    }
}
