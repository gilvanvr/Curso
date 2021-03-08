using System;

namespace Curso
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double CalcularArea()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return raiz;
        }

        public void VerificaMaior()
        {
            if (A>B)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (B>A)
            {
                Console.WriteLine("Maior área: Y");
            }
            else
            {
                Console.WriteLine("Áreas iguais");
            }
        }
    }
}
