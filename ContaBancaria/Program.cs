using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre com o Número da conta: ");
            string conta = Console.ReadLine().ToUpper();

            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine().ToUpper();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoinicial = char.Parse(Console.ReadLine().ToUpper());

            if (depositoinicial == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c = new Conta(conta, titular, deposito);
            }
            else
            {
                c = new Conta(conta, titular);
            }

            Console.WriteLine("\nDados da conta: \n" + c);

            Console.Write("\nEntre com valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c.Deposito(valorDeposito);

            Console.WriteLine("\nDados da conta Atualizados: \n" + c);

            Console.Write("\nEntre com valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(valorSaque);

            Console.WriteLine("\nDados da conta Atualizados: \n" + c);

        }
    }
}
