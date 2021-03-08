using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f;
            f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.SalarioLiquido();
            Console.WriteLine("Funcionário: " + f);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.AumentarSalario(percent);

            Console.Write("Dados Atualizados: " + f);
        }
    }
}
