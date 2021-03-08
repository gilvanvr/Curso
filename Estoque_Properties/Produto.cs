using System;
using System.Globalization;

namespace Estoque_Properties
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int qtd)
        {
            _nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome
                    + ", R$"
                    + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", " + Qtd + " unidades, Total: R$"
                    + total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
