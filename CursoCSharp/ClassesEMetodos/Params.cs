using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Params
    {
        public static void Recepcionar(params string[] pessoas) //passar parametros variaveis do mesmo tipo ,agrupa varios valores dentro de um array
        {

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }

        }
        public static void  Executar()
        {
            Recepcionar("Maria","Leandro","Mauricio","Eliza");
        }
    }
}
