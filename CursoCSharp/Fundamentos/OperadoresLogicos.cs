using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executarTrabalho1 = true;
            var executarTrabalho2 = false;

            var comprouTv50 = executarTrabalho1 && executarTrabalho2;
            Console.WriteLine("Comprou a tv 50? {0}", comprouTv50);


            var comprouSorvete = executarTrabalho1 || executarTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            var comprouTv32 = executarTrabalho2 ^ executarTrabalho1;
            Console.WriteLine("Comprou tv 32? {0}", comprouTv32);


        }
    }
}
