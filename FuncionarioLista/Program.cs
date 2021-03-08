using System;
using System.Collections.Generic;
using System.Globalization;

namespace FuncionarioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão cadastrados? ");
            int qtd = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("\nEmployee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == idIncrease);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
