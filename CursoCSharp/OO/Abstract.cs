using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public  string ToquePadrao()
        {
            return "trim trim trim";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Assistente Samsung";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Assitente Iphone";
        }
    }
    public class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach(var c in celulares)
            {
                Console.WriteLine(c.Assistente());
            }


        }
    }
}
