using System;
using System.Globalization;

namespace ProdutosVET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Produto: ");
                string produto = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Nome = produto, Preco = preco };

            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Preco;
            }

            double avg = sum / n;

            Console.WriteLine("Preço médio: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
