using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegateFuncAnonima
    {
        delegate string StringOperacao(string a);
        public static void Executar()
        {
            StringOperacao inverter = delegate (string a)
            {
                char[] charArray = a.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.Write(inverter("mauricio"));

        }
    }
}
