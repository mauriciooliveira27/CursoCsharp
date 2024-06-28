using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            string nome;
            int idade;
            double salario;

            Console.WriteLine("Qual é o seu nome?: ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu salário?: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome} --- Idade: {idade} --- Salário: {salario}");
             
        }
    }
}
