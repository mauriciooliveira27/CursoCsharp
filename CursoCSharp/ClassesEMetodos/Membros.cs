using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {   
            Pessoa sicrano  = new Pessoa();
            sicrano.Nome = "Mauricio";
            sicrano.Idade = 27;

            sicrano.ApresentarConsole();


            var fulano = new Pessoa();
            fulano.Nome = "Leandro";
            fulano.Idade = 30;

            fulano.ApresentarConsole();
            

        }
    }
}
