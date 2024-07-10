using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        
        public double Sacar(double quantidade)
        {
            if (quantidade > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= quantidade;

            return Saldo;
        }
    }
    public class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(500);

            try
            {
                var result = conta.Sacar(60);
                Console.WriteLine($"Saque , seu novo saldo : {result}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message );
            }
            finally
            {
                Console.WriteLine("Volte Sempre!");
            }
        }
    }
}
