using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double SomarNotas()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double CalcularDiferenca()
        {
            return 60 - SomarNotas();
        }

        public override string ToString()
        {
            if (SomarNotas() >= 60)
            {
                return "NOTA FINAL: " 
                    + SomarNotas().ToString("F2",CultureInfo.InvariantCulture) 
                    + "\nAPROVADO.";
            }
            else
            {
                return "NOTA FINAL: " 
                    + SomarNotas().ToString("F2", CultureInfo.InvariantCulture) 
                    + "\nREPROVADO\nFALTARAM: "
                    + CalcularDiferenca().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS.";
            }
        }
    }
}
