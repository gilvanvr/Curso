using ContaBancariaException.Entities;
using ContaBancariaException.Entities.Exceptions;
using System;
using System.Globalization;

namespace ContaBancariaException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: R$ ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: R$ ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: R$ ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("New Balance: R$ " + acc.WithDraw(amount));
            }
            catch (DomainExceptions ex)
            {
                Console.WriteLine("Withdraw Error: " + ex.Message);
            }
        }
    }
}
