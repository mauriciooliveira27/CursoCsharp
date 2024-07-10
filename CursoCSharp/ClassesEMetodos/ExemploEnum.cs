using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror,animacao, Comedia};

    public class Filme()
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    internal class ExemploEnum
    {
        public static void Executar()
        {
           

            var filmeDeTerror = new Filme();
            filmeDeTerror.Titulo = "Massacre da serra elétrica 3";
            filmeDeTerror.GeneroDoFilme = Genero.Terror;

            
            string titulo = filmeDeTerror.Titulo;
            string genero = filmeDeTerror.GeneroDoFilme.ToString();
            Console.WriteLine($"FILME : {titulo} --- Gênero : {genero}");
            
        }
    }
}
