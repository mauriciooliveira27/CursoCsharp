﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes , int ano) 
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia , mes, ano);
        }
        public static void Executar()
        {
            Formatar(mes: 9, ano: 1996, dia: 16);
        }

    }
}
