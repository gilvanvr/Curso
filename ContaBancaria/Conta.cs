using System;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public string ContaBancaria { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(string contaBancaria, string nome)
        {
            ContaBancaria = contaBancaria;
            Nome = nome;
        }

        public Conta(string contaBancaria, string nome, double deposito) : this(contaBancaria, nome)
        {
            Deposito(deposito);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= (saque + 5);
        }

        public override string ToString()
        {
            return "Conta: " + ContaBancaria + ", Titular: " + Nome + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture) + ".";
        }

    }
}
