using System;

namespace HotelVET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos vão alugar o quarto? ");
            int qtd = int.Parse(Console.ReadLine());

            Hotel[] vect = new Hotel[10];

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("\nReserva " + (i + 1) + ": ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                int quartoCont = quarto - 1;

                vect[quartoCont] = new Hotel { Nome = nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine("\nQuartos alugados: \n");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine((vect[i].Quarto) + ": " + vect[i].Nome + ", " + vect[i].Email);
                }
            }
        }
    }
}
