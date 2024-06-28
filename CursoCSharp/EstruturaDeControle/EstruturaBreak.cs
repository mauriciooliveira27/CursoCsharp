
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaBreak
    {

        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 50);

            bool numeroAchado = false;

            int i = 0;

            while (!numeroAchado)
            {
                i++;

                if ( i == numero)
                {   
                    Console.WriteLine("Numero achado {0} == {1}", i , numero);
                    break;
                }
            }
          
            
        }
    }
}
