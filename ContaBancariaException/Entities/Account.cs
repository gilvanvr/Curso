using ContaBancariaException.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancariaException.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public double WithDraw(double amount)
        {
            if (Balance <= 0 || amount > WithDrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit.");
            }
            if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance.");
            }

            return Balance -= amount;
        }


    }
}
