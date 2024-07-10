using System;
using System.IO;


namespace CursoCSharp.api
{
    internal class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCshap".ParseHome();
            var novoDirDestino = @"~/PastaCsharpDestino".ParseHome();
            var dirProjeto = @"C:/Users/mauri/OneDrive/Área de Trabalho/estudos/C#/CursoCSharp/CursoCSharp";

            if(Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }
            if(Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.Write("=========Directory=========");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach( var pasta in pastas )
            {
                Console.WriteLine(pasta.ToString());
            }
        }
    }
}
