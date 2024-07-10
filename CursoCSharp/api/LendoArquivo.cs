using System;
using System.IO;

namespace CursoCSharp.api
{
    internal class LendoArquivo
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivo.txt".ParseHome();


            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Produto");
                    sw.WriteLine("Caneta Bic");
                }

            }

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }
        }
    }
}
