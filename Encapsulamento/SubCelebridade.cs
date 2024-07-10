using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public  class SubCelebridade
    {
        // Todos
        public string InfoPublic = "Tenho um instagram";

        //Herença
        protected string CorDosOlhos = "Verde";

        // mesmo projeto (Assembly)
        internal ulong NumeroCelular = 55548452122;

        //Herança ou no mesmo projeto
        protected internal string JeitoDeFalar = "Muitas Girias";

        //mesma class ou Herança no mesmo projeto 
        private protected string SegredoDeFamilia = "Bla Bla";

        //private é o padrão
        bool UsarMuitoPhotoshop = false;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade");

            Console.WriteLine(InfoPublic);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);   
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsarMuitoPhotoshop);
        }



    }
}
