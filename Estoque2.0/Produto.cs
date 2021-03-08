using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estoque2._0
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public Produto()
        {
            Qtd = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int qtd) : this(nome, preco)
        {
            Qtd = qtd;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;
        }

        public void AdicionarProdutos(int qtd)
        {
            Qtd += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Qtd -= qtd;
        }

        public override string ToString()
        {
            double total = ValorTotalEmEstoque();
            return Nome
                    + ", R$"
                    + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", " + Qtd + " unidades, Total: R$"
                    + total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
