using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida() { }
    }


    public class Feijao : Comida
    {
        
    }

    public class Arroz : Comida
    {
        
    }

    public class Carne : Comida
    {
        
    }

    public class Pessoa
    {
        public double peso=80;

        public void Comer(Comida comida)
        {
            peso += comida.Peso;
        }
    }

    public class Polimorfismo
    {
        public static void Executar()
        {
            Feijao feijao = new Feijao();
            feijao.Peso = 3.5;

            Arroz arroz = new Arroz();
            arroz.Peso = 5.5;


            Carne carne = new Carne();
            carne.Peso = 10.5;

            Pessoa pessoa = new Pessoa();
            pessoa.Comer(feijao);
            pessoa.Comer(arroz);
            pessoa.Comer(carne);

            Console.WriteLine($"Peso : {pessoa.peso}");
        }
    }
}
