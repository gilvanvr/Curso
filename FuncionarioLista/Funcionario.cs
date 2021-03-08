using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FuncionarioLista
{
    class Funcionario
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Name = nome;
            Salary = salario;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100.00);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
