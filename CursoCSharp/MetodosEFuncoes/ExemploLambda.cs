using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {

        public static void Executar()
        {
            Action algoNoConsole = () => 
            {
                Console.WriteLine("Lambda em C#!");
            };

            algoNoConsole();

            Func<int,int> jogadorDado = (x) => { return x + 1; };

            Console.WriteLine(jogadorDado(1));
        }
    }
}
