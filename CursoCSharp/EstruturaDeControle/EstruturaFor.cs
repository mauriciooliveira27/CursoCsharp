using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
           double somatoria = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamahoTurma);

            for (int i =  1; i <= tamahoTurma; i++)
            {
                Console.WriteLine("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatoria += notaAtual; 

                double media = tamahoTurma > 0? somatoria / tamahoTurma : 0;    
                Console.WriteLine("Media da turma: {0} ", media);
            }
        }
    }
}
