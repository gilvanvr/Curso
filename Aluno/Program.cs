using System;
using System.Globalization;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno;
            aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.SomarNotas();
            aluno.CalcularDiferenca();

            Console.WriteLine(aluno);
        }
    }
}
