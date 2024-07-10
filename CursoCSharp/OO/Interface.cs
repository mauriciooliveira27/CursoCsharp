using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {

            return a + b;

        }
    }

    public class Subtrcao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {

            return a - b;

        }
    }

    public class Calculadora
    {
        List<OperacaoBinaria> Operacoes = new List<OperacaoBinaria>
            {
                new Soma(),
                new Subtrcao(),
            };

        public string ExecutarOpercoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in Operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}";
            }

            return resultado;
        }

    }
    public class Interface
    {
        public static void Executar()
        {
            var cal = new Calculadora();
            var resultado = cal.ExecutarOpercoes(5,5);

            Console.WriteLine(resultado);
        }
    }
}
