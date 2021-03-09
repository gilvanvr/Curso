using HerancaPolimorfismo_Funcionario.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data: ");
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name+" - $ "+ emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
