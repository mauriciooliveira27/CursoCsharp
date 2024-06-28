using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {   
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N) ?");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 7 && bomComportamento)
            {
                Console.WriteLine("quadro de honra!");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
            
        }
    }
}
