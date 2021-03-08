using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Retangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        double area, perimetro, diagonal;


        public double Area()
        {
            return area = Largura * Altura;
        }

        public double Perimetro()
        {
            return perimetro = 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return "AREA: " + area.ToString("F2", CultureInfo.InvariantCulture)
                            + ", PERÍMETRO: "
                            + perimetro.ToString("F2", CultureInfo.InvariantCulture)
                            + ", DIAGONAL: "
                            + diagonal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
