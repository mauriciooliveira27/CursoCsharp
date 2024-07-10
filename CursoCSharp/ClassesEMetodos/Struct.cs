using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{   
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;


        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    internal class ExemploStruct
    { 
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 0;
            coordenadaInicial.Y = 0;

            Console.WriteLine("Coordenada Inicial...");
            Console.WriteLine($"X = {coordenadaInicial.X} ------ Y = {coordenadaInicial.Y}");
        }
    }
}
