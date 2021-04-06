using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe um número: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Informe outro número: ");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;

                Console.WriteLine("Resultado: " + result);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.GetType());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error! " + e.Message);
            }
            finally
            {
                Console.WriteLine("Programa Finalizado!");
            }

        }
    }
}
