using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }

    public class List
    {
        public static void Executar()
        {
            var livro = new Produto("Critica da razão pura", 199.50);
            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Renne Descartes - A historia completa", 789.87),
                new Produto("Platão o conto nunca contado", 1547.84)
            };

            carrinho.AddRange(combo);

            foreach (var item in carrinho)
            {
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Preco);

                var index = carrinho.IndexOf(item);
                Console.WriteLine(index);



                

            }

            

        }

        
    }
}
