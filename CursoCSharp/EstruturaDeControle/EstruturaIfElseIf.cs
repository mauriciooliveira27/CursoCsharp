using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar()
        {
            double nota;

            Console.WriteLine("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            
            double.TryParse(entrada, out nota);
            Console.WriteLine(nota);

            if(nota >= 9.0)
            {
                Console.WriteLine("Quadro de Honra!");
            }else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }else if (nota >= 6.0)
            {
                Console.WriteLine("Por pouco mas passou");
            }else
            {
                Console.WriteLine("Reprovado");
            }
        }

    }
}
