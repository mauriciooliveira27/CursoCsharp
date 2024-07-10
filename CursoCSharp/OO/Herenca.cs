using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    public class Carro
    {
        protected readonly int VelociadadeMaxima;
        int VelocidadeAtual;

        public Carro(int velociadadeMaxima)
        {
            VelociadadeMaxima = velociadadeMaxima;
            
        }
        public int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;
            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;

            }else if (novaVelocidade > VelociadadeMaxima)
            {
                VelocidadeAtual = VelociadadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Freiar()
        {
            return AlterarVelocidade(-5);
        }

        

    }


    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(450)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(20);
        }

        public new int Freiar()
        {
            return AlterarVelocidade(-20);
        }
    }
    internal class Herenca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Freiar());

            Console.WriteLine("Ferrari...");
            Ferrari ferrari = new Ferrari();
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine (ferrari.Freiar());
        }
    }
}
