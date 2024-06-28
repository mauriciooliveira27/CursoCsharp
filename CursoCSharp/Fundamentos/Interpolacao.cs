using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string marca = "Dell";
            string produto = "NoteBook";
            double preco = 2500;

            Console.WriteLine($"Exibindo as variaveis {marca} --- {produto} --- {preco} com interpolação de strings");
        }
    }
}
