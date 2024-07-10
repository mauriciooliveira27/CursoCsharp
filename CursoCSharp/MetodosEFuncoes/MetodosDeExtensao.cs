using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensaoInteiro
    {
        public static int Soma(this int num, int num2) { return num + num2; }   
    }
    public  class MetodosDeExtensao
    {
        public static void Executar()
        {

                int numero = 5;
                Console.WriteLine(numero.Soma(5));

        }
    }
}
