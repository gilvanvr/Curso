using Bussines_Heranca.Entities;
using System;

namespace Bussines_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BussinesAccount bacc = new BussinesAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BussinesAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING

            BussinesAccount acc4 = (BussinesAccount)acc2;
            acc4.Loan(100.00);

            if (acc3 is BussinesAccount)
            {
                // [FORMA 1] BussinesAccount acc5 = (BussinesAccount)acc3;
                BussinesAccount acc5 = acc3 as BussinesAccount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Updated");
            }
        }
    }
}
