using System;
using System.IO;

namespace CursoCSharp.api
{
    internal class ExemploFileInfo
    {
        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            using (StreamWriter sw = new StreamWriter(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original");
            }


            FileInfo fileInfo = new FileInfo(caminhoOrigem);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.IsReadOnly);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Extension);

            fileInfo.CopyTo(caminhoCopia);
            fileInfo.MoveTo(caminhoDestino);
        }
    }
}
