using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimeSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {

            return x + y;
            
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(10,10));
        }
    }
}
