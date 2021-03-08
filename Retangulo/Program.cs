using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            r.Area();
            r.Perimetro();
            r.Diagonal();

            Console.Write(r);
        }
    }
}
