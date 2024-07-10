using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Moto
    {
        private string Marca;
        private string Modelo;
        private int ano;

        public Moto(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            this.ano = ano;
        }

        public Moto() { }

        public string GetMarca()
        {

            return Marca; 
        }

        public void SetMarca(string marca)
        {

            Marca = marca; 
        
        }
        
        public class GetSet
        {
            public static void Executar()
            {

                Moto moto = new Moto("Yamaha", "Fazer", 2024);
                string result = moto.GetMarca();
                Console.WriteLine(result);

            }
        }
    }
}
