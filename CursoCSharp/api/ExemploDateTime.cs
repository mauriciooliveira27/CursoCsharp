using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.api
{
    internal class ExemploDateTime
    {

        public static void Executar()
        {
            var dateTime = new DateTime(year: 2022, day: 16, month: 09, hour:16, minute: 50, second: 30);

            Console.WriteLine(dateTime.ToString());

            Console.WriteLine(dateTime.Day);

            var hojeSemHora = DateTime.Today;

            var hojeComHora = DateTime.Now;

            Console.WriteLine(hojeComHora.ToString());
            Console.WriteLine(hojeSemHora.ToString());

        }
    }
}
