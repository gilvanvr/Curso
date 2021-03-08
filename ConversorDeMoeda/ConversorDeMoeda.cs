using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoeda
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double ConversorDolar(double quantia, double cotacao)
        {
            return (cotacao * quantia) + ((cotacao * quantia) * Iof/100);
        }
    }
}
