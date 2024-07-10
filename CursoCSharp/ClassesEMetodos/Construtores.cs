using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            this.ano = ano;
        }
    }

    class Construtor()
    {
        public static void Executar()
        {
            Carro carro = new Carro("A7", "AUDI", 1997);

           

        }
    }


}
