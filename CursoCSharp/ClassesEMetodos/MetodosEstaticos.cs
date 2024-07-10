using System;

namespace CursoCSharp.ClassesEMetodos
{


    class Pessoa_02
    {
        static string nome_class = "CLASS";
        string nome_instancia;

        public Pessoa_02()
        {
            nome_instancia = "INSTÂNCIA";


        }

        public string ExibirIntancia()
        {

            return nome_instancia; 
        
        }

        public static string ExibirClass()
        {
            return nome_class;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {

            Pessoa_02 pessoa = new Pessoa_02();
            string msg_instancia = pessoa.ExibirIntancia();
            string msg_class = Pessoa_02.ExibirClass();

            Console.Write($"{msg_instancia}, {msg_class}");
        }

        

    }
}