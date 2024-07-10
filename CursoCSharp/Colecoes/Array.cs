using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "1";
            alunos[1] = "2";
            alunos[2] = "3";
            alunos[3] = "4";
            alunos[4] = "5";
            foreach (string s in alunos)
            {
                Console.WriteLine(s);
            }
        }
    }
}
