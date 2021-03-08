using System;
using System.Globalization;

namespace Estoque2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p2 = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int qtdEstoque = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Produto p = new Produto(nome, preco, qtdEstoque);
            Produto p = new Produto(nome, preco);

            Produto p3 = new Produto()
            {
                Nome = "TV",
                Preco = 500.00,
                Qtd = 10
            };

            Console.WriteLine("Dados do Produto: " + p);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("Dados Atualizado: " + p);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine("Dados Atualizado: " + p);
        }
    }
}
