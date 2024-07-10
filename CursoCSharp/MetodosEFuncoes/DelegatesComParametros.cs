using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegatesComParametros
    {   
        public delegate int Operacao(int a, int b);

        public static int Soma(int a, int b)
        {
            return a + b;
        }

        public static string Calculadora(Operacao op, int a , int b)
        {
            var resultado = op(a, b);

            return "Resultado: " + resultado;

        }
        public static void Executar()
        {
            Operacao subtracao = (int a, int b) => a - b;
            Console.WriteLine(Calculadora(subtracao, 40 , 20));
            Console.WriteLine(Calculadora(Soma, 2, 2));


        }
    }
}
