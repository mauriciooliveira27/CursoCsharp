using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum()
    {
        public int Somar( double a , int b)
        {
            return (int) a + b;
        }

        public int Somar(int a , double b )
        {
            return a + (int) b;
        }   
        
        public double Somar(double a , int b, int c)
        {
            return a + (double) b + (double) c;
        }

        public int Subtrair(int a , double b)

        {   
            return a - (int) b; 
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a , int b)
        {
            memoria = a + b;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;

        }

        public CalculadoraCadeia limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {   
            CalculadoraComum calculadora = new CalculadoraComum();
            var result_01 = calculadora.Somar(2.5, 50);
            Console.WriteLine("Retorno do primeiro método Somar()   : {0}", result_01 );

            var result_02 = calculadora.Somar(60, 5.2);
            Console.WriteLine("Retorno do segundo método Somar()    : {0}", result_02 );

            var result_03 = calculadora.Somar(5.2, 2, 3);
            Console.WriteLine("Retorno do terceiro método Somar()   : {0}", result_03 );

            var result_04 = calculadora.Subtrair(5,2.5);
            Console.WriteLine("Retorno do método Subtrair() : {0}", result_04 );

            var result_05 = calculadora.Multiplicar(5, 5);
            Console.WriteLine("Retorno do método Multiplicar() : {0}", result_05 );

            CalculadoraCadeia calCadeia = new CalculadoraCadeia();

            calCadeia.Somar(2, 3).Multiplicar(5).Imprimir().limpar().Imprimir();
            
        }

    }
}
