using System;
using System.Collections.Generic;
using Encapsulamento;


namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho não reconhecido");

            Console.WriteLine(InfoPublic);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsarMuitoPhotoshop);

        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amigoDistante = new SubCelebridade();
        public void MeusAcesso()
        {
            Console.WriteLine("Filho não reconhecido");

            Console.WriteLine(amigoDistante.InfoPublic);
            //Console.WriteLine(amigoDistante.CorDosOlhos);
            //Console.WriteLine(NumeroCelular);
            //Console.WriteLine(amigoDistante.JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsarMuitoPhotoshop);

        }
    }

    public class Encapsulamentos
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcesso();

        }
    }
}



