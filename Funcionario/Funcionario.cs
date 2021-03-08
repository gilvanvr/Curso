using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario
{
    class Funcionario
    {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;
        double Salario;

        public double SalarioLiquido()
        {

            return Salario = SalarioBruto - Imposto;
        }

        public void AumentarSalario(double p)
        {
            Salario = (SalarioBruto * (p / 100)) + SalarioLiquido();
        }

        public override string ToString()
        {
            return Nome + ", R$ " + Salario;
        }
    }
}
