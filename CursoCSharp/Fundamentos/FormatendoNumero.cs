using System;
using System.Collections.Generic;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.17547;
            Console.WriteLine(valor.ToString("F2"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }

    }
}
