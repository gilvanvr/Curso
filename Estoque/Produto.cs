using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

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
