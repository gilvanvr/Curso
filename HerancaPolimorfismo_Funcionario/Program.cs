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
            //Decimal PercentualToleranciaEixo = Convert.ToDecimal(Convert.ToInt32((float.Parse("10.0".Replace(".", ",")))));
            // string teste1 = "5.0".Replace(".",",") ?? "0";
            //   decimal teste = Convert.ToDecimal(teste1);
            //// int teste2 = Convert.ToInt32(PercentualToleranciaEixo);
            //// Decimal dec = teste;

            ////  Console.WriteLine(dec); 
            ////Console.WriteLine(decimal.Parse("10.0", CultureInfo.InvariantCulture));
            ////decimal t = decimal.Parse("10.0", CultureInfo.InvariantCulture);
            ////Console.WriteLine(t);

            //Console.WriteLine(decimal.Round(teste));

            string percentualToleranciaEixos = "5.0";
            string percentualToleranciaPBTC = "10.0";

            string percentualToleranciaEixosS = percentualToleranciaEixos?.Replace(".", ",") ?? "0";
            string percentualToleranciaPBTCS = percentualToleranciaPBTC?.Replace(".", ",") ?? "0";

            decimal percentualToleranciaEixo1 = decimal.Round(Convert.ToDecimal(percentualToleranciaEixosS));
            decimal percentualToleranciaPBTC1 = decimal.Round(Convert.ToDecimal(percentualToleranciaPBTCS));

            Console.WriteLine(percentualToleranciaEixo1);
            Console.WriteLine(percentualToleranciaPBTC1);
        }
    }
}
