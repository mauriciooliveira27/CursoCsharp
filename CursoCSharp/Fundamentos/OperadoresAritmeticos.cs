using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {

        public static void Executar()
        {
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto);
            Console.WriteLine("Preço com desconto é {0}", totalDesconto);

            double peso = 91.5;
            double altura = 1.79;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("Seu IMC é {0}", imc);


            int par = 24 % 2;
            int impar = 3 % 2;

            if (par == 0 && impar != 0)
            {
                Console.WriteLine("Variavel PAR é PAR : {0} e a variavel IMPAR é IMPAR {1}", par, impar);
            }

            
           
        }
    }
}
