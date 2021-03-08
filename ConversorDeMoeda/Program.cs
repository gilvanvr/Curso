using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: R$ "
               + ConversorDeMoeda.ConversorDolar(quantia, cotacao).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
